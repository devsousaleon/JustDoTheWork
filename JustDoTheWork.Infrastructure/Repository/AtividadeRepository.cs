using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;
        private readonly UsuarioSessaoDTO? _usuario;

        public AtividadeRepository(JustDoTheWorkDbContextFactory dbContextFactory, UsuarioSessaoDTO? usuario = null)
        {
            _dbContextFactory = dbContextFactory;
            _usuario = usuario;
        }

        public string Inclusao(Atividade atividade)
        {
            if (_usuario == null || (!_usuario.EhTechLead && !string.Equals(_usuario.TipoUsuario, FluxoAtividade.Historiador, StringComparison.OrdinalIgnoreCase)))
                return "Somente o Historiador ou o Tech Lead pode cadastrar atividades.";

            if (!_usuario.EhTechLead && atividade.UsuarioResponsavelId != _usuario.Id)
                return "A atividade deve iniciar vinculada ao Historiador que está cadastrando.";

            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                if ((!_usuario.EhTechLead || atividade.UsuarioResponsavelId.HasValue) && !ResponsavelValido(context, atividade.UsuarioResponsavelId, EtapaAtividade.Historiador))
                    return "Selecione um Historiador para iniciar a atividade.";
                if (!context.Projetos.Any(projeto => projeto.Id == atividade.ProjetoId))
                    return "Selecione um projeto existente.";

                atividade.Status = StatusAtividade.Pendente;
                atividade.Etapa = EtapaAtividade.Historiador;
                atividade.DataFinalizacao = null;
                context.Atividades.Add(atividade);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception exception)
            {
                return "Ocorreu um erro ao incluir a atividade! " + exception.Message;
            }
        }

        public string Edicao(AtividadeDTO atividade)
            => ExecutarAlteracao(atividade.Id, (context, existente) =>
            {
                if (!ConsultaAtividade.PodeEditar(existente, _usuario))
                    return "Somente o responsável pela etapa ou o Tech Lead pode editar esta atividade.";
                if (!context.Projetos.Any(projeto => projeto.Id == atividade.ProjetoId))
                    return "Selecione um projeto existente.";

                AtualizarDados(existente, atividade);
                return "";
            }, atividade);

        public string AvancarAtividade(AtividadeDTO atividade, int? usuarioDestinoId)
            => ExecutarAlteracao(atividade.Id, (context, existente) =>
            {
                if (!ConsultaAtividade.PodeMovimentar(existente, _usuario))
                    return "Somente o responsável pela etapa atual pode avançar esta atividade.";
                if (!context.Projetos.Any(projeto => projeto.Id == atividade.ProjetoId))
                    return "Selecione um projeto existente.";

                var proximaEtapa = FluxoAtividade.ProximaEtapa(existente.Etapa);
                if (proximaEtapa != EtapaAtividade.Finalizada && !ResponsavelValido(context, usuarioDestinoId, proximaEtapa))
                    return "Selecione um usuário do tipo " + FluxoAtividade.TipoUsuarioPorEtapa(proximaEtapa) + ".";

                if (proximaEtapa == EtapaAtividade.Finalizada && usuarioDestinoId.HasValue)
                    return "A conclusão pelo QA Tester não possui um próximo responsável.";

                AtualizarDados(existente, atividade);
                FinalizarExecucoes(context, existente.Id);
                if (existente.Etapa == EtapaAtividade.Desenvolvedor)
                    existente.UltimoDesenvolvedorId = existente.UsuarioResponsavelId;
                existente.RetornoExclusivo = false;
                existente.Etapa = proximaEtapa;
                existente.Status = proximaEtapa == EtapaAtividade.Finalizada ? StatusAtividade.Finalizado : StatusAtividade.Pendente;
                existente.DataFinalizacao = proximaEtapa == EtapaAtividade.Finalizada ? RelogioAplicacao.Agora : null;
                if (proximaEtapa != EtapaAtividade.Finalizada)
                    existente.UsuarioResponsavelId = usuarioDestinoId;
                return "";
            }, atividade);

        public string DevolverDesenvolvedor(AtividadeDTO atividade)
            => ExecutarAlteracao(atividade.Id, (context, existente) =>
            {
                if (existente.Etapa != EtapaAtividade.QATester || !ConsultaAtividade.PodeMovimentar(existente, _usuario))
                    return "Somente o QA Tester responsável pode devolver a atividade ao desenvolvedor.";
                var desenvolvedorId = context.Execucoes
                    .Where(execucao => execucao.AtividadeId == existente.Id && execucao.Etapa == EtapaAtividade.Desenvolvedor && execucao.UsuarioId != null && execucao.DataFim != null)
                    .OrderByDescending(execucao => execucao.DataFim).ThenByDescending(execucao => execucao.Id)
                    .Select(execucao => execucao.UsuarioId).FirstOrDefault() ?? existente.UltimoDesenvolvedorId;
                if (!desenvolvedorId.HasValue)
                    return "Esta atividade não registra o desenvolvedor anterior. O Tech Lead precisa regularizar o histórico antes da devolução.";
                if (!ResponsavelValido(context, desenvolvedorId, EtapaAtividade.Desenvolvedor))
                    return "O desenvolvedor anterior precisa continuar cadastrado com o perfil Desenvolvedor.";
                if (!context.Projetos.Any(projeto => projeto.Id == atividade.ProjetoId))
                    return "Selecione um projeto existente.";
                AtualizarDados(existente, atividade);
                FinalizarExecucoes(context, existente.Id);
                existente.Etapa = EtapaAtividade.Desenvolvedor;
                existente.Status = StatusAtividade.Pendente;
                existente.DataFinalizacao = null;
                existente.UsuarioResponsavelId = desenvolvedorId;
                existente.UltimoDesenvolvedorId = desenvolvedorId;
                existente.RetornoExclusivo = true;
                return "";
            }, atividade);

        public string CancelarAtividade(AtividadeDTO atividade)
            => ExecutarAlteracao(atividade.Id, (context, existente) =>
            {
                if (!ConsultaAtividade.PodeCancelar(existente, _usuario))
                    return "Somente o responsável pela etapa ou o Tech Lead pode cancelar esta atividade.";

                FinalizarExecucoes(context, existente.Id);
                existente.Status = StatusAtividade.Cancelado;
                existente.DataFinalizacao = RelogioAplicacao.Agora;
                return "";
            }, atividade);

        public string VincularResponsavel(AtividadeDTO versao, int usuarioResponsavelId)
            => ExecutarAlteracao(versao.Id, (context, atividade) =>
            {
                if (_usuario?.EhTechLead != true || atividade.UsuarioResponsavelId.HasValue || !FluxoAtividade.EstaAberta(atividade.Status))
                    return "Somente o Tech Lead pode vincular um responsável às atividades antigas sem vínculo.";

                if (!ResponsavelValido(context, usuarioResponsavelId, atividade.Etapa))
                    return "Selecione um responsável do tipo " + FluxoAtividade.TipoUsuarioPorEtapa(atividade.Etapa) + ".";

                FinalizarExecucoes(context, atividade.Id);
                atividade.UsuarioResponsavelId = usuarioResponsavelId;
                atividade.Status = StatusAtividade.Pendente;
                return "";
            }, versao);

        public string ExclusaoPorId(AtividadeDTO versao)
            => ExecutarAlteracao(versao.Id, (context, atividade) =>
            {
                if ((_usuario?.EhTechLead != true && (_usuario?.Id != atividade.UsuarioResponsavelId ||
                    !string.Equals(_usuario?.TipoUsuario, FluxoAtividade.Historiador, StringComparison.OrdinalIgnoreCase))) ||
                    atividade.Etapa != EtapaAtividade.Historiador || atividade.Status is not (StatusAtividade.Pendente or StatusAtividade.Analise))
                    return "Somente o Historiador responsável ou o Tech Lead pode excluir uma atividade pendente ou em análise na primeira etapa.";

                if (context.Execucoes.Any(execucao => execucao.AtividadeId == versao.Id))
                    return "Uma atividade com execuções deve ser cancelada em vez de excluída.";

                context.Atividades.Remove(atividade);
                return "";
            }, versao);

        public AtividadeDTO BuscarPorId(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var resultado = ConsultaAtividade.Filtrar(context.Atividades.AsNoTracking(), _usuario)
                .Where(atividade => atividade.Id == id)
                .Select(atividade => new AtividadeDTO
                {
                    Id = atividade.Id,
                    Nome = atividade.Nome,
                    Status = atividade.Status,
                    Descricao = atividade.Descricao,
                    DataCriacao = atividade.DataCriacao,
                    DataFinalizacao = atividade.DataFinalizacao,
                    ProjetoId = atividade.ProjetoId,
                    Etapa = atividade.Etapa,
                    UsuarioResponsavelId = atividade.UsuarioResponsavelId,
                    UltimoDesenvolvedorId = atividade.UltimoDesenvolvedorId,
                    RetornoExclusivo = atividade.RetornoExclusivo,
                    TemExecucoes = context.Execucoes.Any(execucao => execucao.AtividadeId == atividade.Id),
                    Responsavel = context.Usuarios.Where(usuario => usuario.Id == atividade.UsuarioResponsavelId)
                        .Select(usuario => usuario.Nome).FirstOrDefault() ?? "Sem responsável"
                }).FirstOrDefault()!;
            if (resultado != null)
                resultado.Revisao = RevisaoAtividade.Calcular(resultado);
            return resultado!;
        }

        public IEnumerable<ResultadoPesquisaAtividadeDTO> Pesquisar(FiltroPesquisaAtividadeDTO filtro)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var atividades = ConsultaAtividade.Filtrar(context.Atividades.AsNoTracking(), _usuario);
            var nome = filtro.Nome?.Trim();
            if (!string.IsNullOrEmpty(nome))
                atividades = atividades.Where(atividade => atividade.Nome.Contains(nome));
            if (filtro.Status is > 0)
            {
                var status = (StatusAtividade)filtro.Status;
                atividades = atividades.Where(atividade => atividade.Status == status);
            }
            if (filtro.ProjetoId is > 0)
                atividades = atividades.Where(atividade => atividade.ProjetoId == filtro.ProjetoId);
            if (filtro.DataCriacao.HasValue)
            {
                var inicio = filtro.DataCriacao.Value.Date;
                var fim = inicio.AddDays(1);
                atividades = atividades.Where(atividade => atividade.DataCriacao >= inicio && atividade.DataCriacao < fim);
            }
            return PesquisarAtividades(context, atividades);
        }

        public IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarHistorico(FiltroPesquisaHistoricoDTO filtro)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var atividades = context.Atividades.AsNoTracking().AsQueryable();
            var execucoes = ConsultaExecucao.Filtrar(context.Execucoes.AsNoTracking(), atividades, _usuario);
            if (filtro.Status is > 0)
            {
                var status = (StatusAtividade)filtro.Status.Value;
                atividades = atividades.Where(atividade => atividade.Status == status);
            }
            if (filtro.ProjetoId is > 0)
                atividades = atividades.Where(atividade => atividade.ProjetoId == filtro.ProjetoId);
            if (filtro.DataCriacaoAtividade.HasValue)
            {
                var inicio = filtro.DataCriacaoAtividade.Value.Date;
                var fim = inicio.AddDays(1);
                atividades = atividades.Where(atividade => atividade.DataCriacao >= inicio && atividade.DataCriacao < fim);
            }
            return (
                from atividade in atividades
                join projeto in context.Projetos.AsNoTracking() on atividade.ProjetoId equals projeto.Id into projetos
                from projeto in projetos.DefaultIfEmpty()
                join execucao in execucoes on atividade.Id equals execucao.AtividadeId
                orderby execucao.DataInicio descending, execucao.Id descending
                select new ResultadoPesquisaHistoricoDTO
                {
                    ExecucaoId = execucao.Id,
                    NomeAtividade = atividade.Nome,
                    NomeProjeto = projeto == null ? "Sem projeto" : projeto.Nome,
                    DataInicioExecucao = execucao.DataInicio,
                    DataFimExecucao = execucao.DataFim,
                    UsuarioId = execucao.UsuarioId,
                    Etapa = execucao.Etapa,
                    Usuario = context.Usuarios.Where(usuario => usuario.Id == execucao.UsuarioId).Select(usuario => usuario.Nome).FirstOrDefault() ?? "Autoria não registrada"
                }).ToList();
        }

        public IEnumerable<ResultadoPesquisaAtividadeDTO> PesquisarPorStatus(params int[] status)
        {
            using var context = _dbContextFactory.CreateDbContext();
            var statusAtividades = status.Select(valor => (StatusAtividade)valor).ToArray();
            var atividades = ConsultaAtividade.Filtrar(context.Atividades.AsNoTracking(), _usuario)
                .Where(atividade => statusAtividades.Contains(atividade.Status));
            return PesquisarAtividades(context, atividades);
        }

        private static List<ResultadoPesquisaAtividadeDTO> PesquisarAtividades(JustDoTheWorkDbContext context, IQueryable<Atividade> atividades)
            => (from atividade in atividades
                join projeto in context.Projetos.AsNoTracking() on atividade.ProjetoId equals projeto.Id into projetos
                from projeto in projetos.DefaultIfEmpty()
                join usuario in context.Usuarios.AsNoTracking() on atividade.UsuarioResponsavelId equals (int?)usuario.Id into responsaveis
                from responsavel in responsaveis.DefaultIfEmpty()
                select new ResultadoPesquisaAtividadeDTO
                {
                    Id = atividade.Id,
                    Atividade = atividade.Nome,
                    Projeto = projeto == null ? "Sem projeto" : projeto.Nome,
                    Status = atividade.Status,
                    Etapa = atividade.Etapa,
                    UsuarioResponsavelId = atividade.UsuarioResponsavelId,
                    RetornoExclusivo = atividade.RetornoExclusivo,
                    Responsavel = responsavel == null ? "Sem responsável" : responsavel.Nome
                }).ToList();

        public string AlterarStatus(AtividadeDTO versao, int novoStatus)
            => ExecutarAlteracao(versao.Id, (context, atividade) =>
            {
                if ((StatusAtividade)novoStatus == StatusAtividade.Executando && ConsultaAtividade.PodeAssumir(atividade, _usuario))
                    atividade.UsuarioResponsavelId = _usuario!.Id;
                else if (!ConsultaAtividade.PodeMovimentar(atividade, _usuario))
                    return "Somente o responsável pela etapa atual pode movimentar esta atividade.";
                if (!FluxoAtividade.TransicaoPermitida(atividade.Status, (StatusAtividade)novoStatus))
                    return "A atividade foi atualizada ou a transição não é permitida. Atualize a pesquisa.";

                if ((StatusAtividade)novoStatus == StatusAtividade.Executando)
                {
                    if (context.Execucoes.Any(execucao => execucao.AtividadeId == versao.Id && execucao.DataFim == null))
                        return "A atividade já possui uma execução em andamento.";
                    context.Execucoes.Add(new Execucao { AtividadeId = versao.Id, DataInicio = RelogioAplicacao.Agora, UsuarioId = _usuario!.Id, Etapa = atividade.Etapa });
                }
                else if (atividade.Status == StatusAtividade.Executando)
                    FinalizarExecucoes(context, versao.Id);

                atividade.Status = (StatusAtividade)novoStatus;
                return "";
            }, versao);

        private string ExecutarAlteracao(int id, Func<JustDoTheWorkDbContext, Atividade, string> alterar, AtividadeDTO versao)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                var origem = context.Database.IsSqlServer()
                    ? context.Atividades.FromSqlInterpolated($"SELECT * FROM dbo.Atividade WITH (UPDLOCK, ROWLOCK) WHERE Id = {id}")
                    : context.Atividades.AsQueryable();
                var atividade = ConsultaAtividade.Filtrar(origem, _usuario).SingleOrDefault(atividade => atividade.Id == id);
                if (atividade == null)
                    return "Atividade não encontrada ou sem permissão de acesso.";
                if (versao.Status != atividade.Status || versao.Etapa != atividade.Etapa || versao.UsuarioResponsavelId != atividade.UsuarioResponsavelId)
                    return "A atividade mudou de etapa ou responsável. Atualize a pesquisa antes de continuar.";
                if (!string.IsNullOrEmpty(versao.Revisao) && versao.Revisao != RevisaoAtividade.Calcular(atividade))
                    return "Os dados ou a descrição foram alterados por outro usuário. Recarregue a atividade antes de gravar.";

                var mensagem = alterar(context, atividade);
                if (!string.IsNullOrWhiteSpace(mensagem))
                    return mensagem;

                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (DbUpdateConcurrencyException)
            {
                return "A atividade foi alterada por outro usuário. Atualize a pesquisa.";
            }
            catch (Exception exception)
            {
                return "Ocorreu um erro ao atualizar a atividade! " + exception.Message;
            }
        }

        private static bool ResponsavelValido(JustDoTheWorkDbContext context, int? usuarioId, EtapaAtividade etapa)
        {
            var tipo = FluxoAtividade.TipoUsuarioPorEtapa(etapa).ToUpperInvariant();
            return usuarioId is > 0 && (from usuario in context.Usuarios
                join tipoUsuario in context.TiposUsuario on usuario.TipoUsuarioId equals tipoUsuario.Id
                where usuario.Id == usuarioId && tipoUsuario.Tipo.ToUpper() == tipo
                select usuario.Id).Any();
        }

        private static void AtualizarDados(Atividade destino, Atividade origem)
        {
            destino.Nome = origem.Nome.Trim();
            destino.Descricao = origem.Descricao;
            destino.ProjetoId = origem.ProjetoId;
        }

        private static void FinalizarExecucoes(JustDoTheWorkDbContext context, int atividadeId)
        {
            var agora = RelogioAplicacao.Agora;
            foreach (var execucao in context.Execucoes.Where(execucao => execucao.AtividadeId == atividadeId && execucao.DataFim == null).ToList())
                execucao.DataFim = agora;
        }
    }
}
