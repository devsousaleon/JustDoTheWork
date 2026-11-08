using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Globalization;
using System.Text;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ModeloRelatorioRepository : IModeloRelatorioRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;
        private readonly UsuarioSessaoDTO? _usuario;

        public ModeloRelatorioRepository(JustDoTheWorkDbContextFactory? dbContextFactory = null, UsuarioSessaoDTO? usuario = null)
        {
            _dbContextFactory = dbContextFactory;
            _usuario = usuario;
        }

        public string Inclusao(ModeloRelatorio modeloRelatorio)
        {
            if (_usuario?.PodeGerenciarModelos != true)
                return "Somente o Historiador ou o Tech Lead pode gerenciar modelos de relatório.";
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                if (!context.TiposModelo.Any(tipo => tipo.Id == modeloRelatorio.TipoModeloId))
                    return "Selecione um tipo de modelo existente.";
                context.ModelosRelatorio.Add(modeloRelatorio);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao incluir o modelo! \n" + ex.Message;
            }
        }

        public string Edicao(ModeloRelatorioDTO modeloRelatorio)
        {
            if (_usuario?.PodeGerenciarModelos != true)
                return "Somente o Historiador ou o Tech Lead pode gerenciar modelos de relatório.";
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                var modeloExistente = CarregarParaAlterar(context, modeloRelatorio.Id);
                if (modeloExistente == null) return "Modelo não encontrado.";
                if (string.IsNullOrEmpty(modeloRelatorio.Revisao) || modeloRelatorio.Revisao != RevisaoModelo.Calcular(modeloExistente))
                    return "O modelo foi alterado por outro usuário. Recarregue antes de gravar.";
                if (!context.TiposModelo.Any(tipo => tipo.Id == modeloRelatorio.TipoModeloId))
                    return "Selecione um tipo de modelo existente.";

                modeloExistente.Ativo = modeloRelatorio.Ativo;
                modeloExistente.Descricao = modeloRelatorio.Descricao;
                modeloExistente.Texto = modeloRelatorio.Texto;
                modeloExistente.TipoModeloId = modeloRelatorio.TipoModeloId;

                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao editar o modelo! \n" + ex.Message;
            }
        }

        public string ExclusaoPorId(int id, string revisao)
        {
            if (_usuario?.PodeGerenciarModelos != true)
                return "Somente o Historiador ou o Tech Lead pode gerenciar modelos de relatório.";
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                var modelosRelatorio = CarregarParaAlterar(context, id);
                if (modelosRelatorio == null) return "Modelo não encontrado.";
                if (string.IsNullOrEmpty(revisao) || revisao != RevisaoModelo.Calcular(modelosRelatorio))
                    return "O modelo foi alterado por outro usuário. Recarregue antes de excluir.";
                context.ModelosRelatorio.Remove(modelosRelatorio);
                context.SaveChanges();
                transacao.Commit();
                return "";
            }
            catch (Exception ex)
            {
                transacao.Rollback();
                return "Erro ao excluir o modelo! \n" + ex.Message;
            }
        }

        public ModeloRelatorioDTO BuscarPorId(int id)
        {
            if (_usuario?.PodeGerenciarModelos != true)
                return null!;
            using var context = _dbContextFactory.CreateDbContext();
            var resultado = context.ModelosRelatorio
                          .AsNoTracking()
                          .Where(mr => mr.Id == id)
                          .Select(mr => new ModeloRelatorioDTO
                          { 
                              Id = mr.Id,
                              Descricao = mr.Descricao,
                              Texto = mr.Texto,
                              Ativo = mr.Ativo,
                              TipoModeloId = mr.TipoModeloId
                          }).FirstOrDefault();
            if (resultado != null) resultado.Revisao = RevisaoModelo.Calcular(resultado);
            return resultado!;
        }

        public byte[]? BuscarModeloHistoricoExecucao()
        {
            if (_usuario?.PodeGerenciarModelos != true)
                return null;
            using var context = _dbContextFactory.CreateDbContext();
            var tipos = TiposHistorico(context);

            return context.ModelosRelatorio
                          .AsNoTracking()
                          .Where(mr => mr.Ativo && tipos.Contains(mr.TipoModeloId))
                          .Select(mr => mr.Texto)
                          .FirstOrDefault();
        }

        public DadosImpressaoHistoricoDTO? BuscarDadosImpressaoHistorico(IReadOnlyCollection<int> execucaoIds, int? usuarioId, int? modeloId = null)
        {
            if (_usuario?.PodeGerenciarModelos != true)
                throw new InvalidOperationException("Somente o Historiador ou o Tech Lead pode imprimir relatórios.");
            usuarioId = _usuario.Id;
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction(IsolationLevel.Serializable);
            var tipos = TiposHistorico(context);
            var modelos = context.ModelosRelatorio.AsNoTracking().Where(modelo => modelo.Ativo && tipos.Contains(modelo.TipoModeloId));
            if (modeloId.HasValue) modelos = modelos.Where(modelo => modelo.Id == modeloId.Value);
            if (modelos.Take(2).Count() > 1)
                throw new InvalidOperationException("Há mais de um modelo ativo. Selecione o modelo que deseja imprimir.");
            var atividadeIds = context.Execucoes.Where(execucao => execucaoIds.Contains(execucao.Id)).Select(execucao => execucao.AtividadeId);
            var tamanho = context.Atividades.Where(atividade => atividadeIds.Contains(atividade.Id)).Sum(atividade => (long?)(atividade.Descricao == null ? 0 : atividade.Descricao.Length)) ?? 0;
            if (tamanho > 40 * 1024 * 1024)
                throw new InvalidOperationException("Os documentos selecionados são muito grandes. Selecione menos execuções para imprimir.");

            var dados = (
                from modelo in modelos
                join tipo in context.TiposModelo.AsNoTracking() on modelo.TipoModeloId equals tipo.Id
                orderby modelo.Id
                select new DadosImpressaoHistoricoDTO
                {
                    Modelo = new ModeloRelatorioDTO
                    {
                        Id = modelo.Id,
                        Descricao = modelo.Descricao,
                        TipoModeloId = modelo.TipoModeloId,
                        Texto = modelo.Texto,
                        Ativo = modelo.Ativo
                    },
                    TipoModelo = new TipoModeloDTO { Id = tipo.Id, Descricao = tipo.Descricao }
                }).FirstOrDefault();

            if (dados == null)
                return null;

            dados.Registros = (
                from execucao in context.Execucoes.AsNoTracking()
                join atividade in ConsultaAtividade.Filtrar(context.Atividades.AsNoTracking(), _usuario) on execucao.AtividadeId equals atividade.Id
                join projeto in context.Projetos.AsNoTracking() on atividade.ProjetoId equals projeto.Id into projetos
                from projeto in projetos.DefaultIfEmpty()
                where execucaoIds.Contains(execucao.Id)
                select new RegistroImpressaoHistoricoDTO
                {
                    Execucao = new ExecucaoDTO
                    {
                        Id = execucao.Id,
                        AtividadeId = execucao.AtividadeId,
                        UsuarioId = execucao.UsuarioId,
                        Etapa = execucao.Etapa,
                        Usuario = context.Usuarios.Where(usuario => usuario.Id == execucao.UsuarioId).Select(usuario => usuario.Nome).FirstOrDefault() ?? "Autoria não registrada",
                        DataInicio = execucao.DataInicio,
                        DataFim = execucao.DataFim
                    },
                    Atividade = new AtividadeDTO
                    {
                        Id = atividade.Id,
                        Nome = atividade.Nome,
                        Descricao = atividade.Descricao,
                        Status = atividade.Status,
                        DataCriacao = atividade.DataCriacao,
                        DataFinalizacao = atividade.DataFinalizacao,
                        ProjetoId = atividade.ProjetoId,
                        Etapa = atividade.Etapa,
                        UsuarioResponsavelId = atividade.UsuarioResponsavelId,
                        Responsavel = context.Usuarios.Where(usuario => usuario.Id == atividade.UsuarioResponsavelId).Select(usuario => usuario.Nome).FirstOrDefault() ?? "Sem responsável"
                    },
                    Projeto = new ProjetoDTO { Id = projeto == null ? 0 : projeto.Id, Nome = projeto == null ? "Sem projeto" : projeto.Nome }
                }).ToList();

            if (usuarioId.HasValue)
            {
                var emissor = (
                    from usuario in context.Usuarios.AsNoTracking()
                    join tipo in context.TiposUsuario.AsNoTracking() on usuario.TipoUsuarioId equals tipo.Id
                    where usuario.Id == usuarioId.Value
                    select new
                    {
                        Usuario = new UsuarioDTO
                        {
                            Id = usuario.Id,
                            Nome = usuario.Nome,
                            Logon = usuario.Logon,
                            TipoUsuarioId = usuario.TipoUsuarioId,
                            Senha = string.Empty
                        },
                        TipoUsuario = new TipoUsuario { Id = tipo.Id, Tipo = tipo.Tipo }
                    }).FirstOrDefault();

                dados.Usuario = emissor?.Usuario;
                dados.TipoUsuario = emissor?.TipoUsuario;
            }

            transacao.Commit();
            return dados;
        }

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO)
        {
            if (_usuario?.PodeGerenciarModelos != true)
                return Array.Empty<ResultadoPesquisaModeloRelatorioDTO>();
            using var context = _dbContextFactory.CreateDbContext();
            var modelos = context.ModelosRelatorio.AsNoTracking().AsQueryable();
            var descricao = filtroPesquisaModeloRelatorioDTO.DescricaoModelo?.Trim();

            if (!string.IsNullOrEmpty(descricao))
                modelos = modelos.Where(mr => mr.Descricao.Contains(descricao));

            if (filtroPesquisaModeloRelatorioDTO.TipoModelo > 0)
                modelos = modelos.Where(mr => mr.TipoModeloId == filtroPesquisaModeloRelatorioDTO.TipoModelo);

            return (from modelo in modelos
                   join tipomodelo in context.TiposModelo.AsNoTracking()
                   on modelo.TipoModeloId equals tipomodelo.Id
                   select new ResultadoPesquisaModeloRelatorioDTO
                   {
                       Id = modelo.Id,
                       Descricao = modelo.Descricao,
                       TipoModelo = tipomodelo.Descricao,
                       Ativo = modelo.Ativo
                   }).ToList();
        }

        private static ModeloRelatorio? CarregarParaAlterar(JustDoTheWorkDbContext context, int id)
            => (context.Database.IsSqlServer()
                ? context.ModelosRelatorio.FromSqlInterpolated($"SELECT * FROM dbo.ModeloRelatorio WITH (UPDLOCK, ROWLOCK) WHERE Id = {id}")
                : context.ModelosRelatorio.AsQueryable()).SingleOrDefault(modelo => modelo.Id == id);

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> PesquisarModelosHistorico()
        {
            if (_usuario?.PodeGerenciarModelos != true) return Array.Empty<ResultadoPesquisaModeloRelatorioDTO>();
            using var context = _dbContextFactory.CreateDbContext();
            var tipos = TiposHistorico(context);
            return context.ModelosRelatorio.AsNoTracking().Where(modelo => modelo.Ativo && tipos.Contains(modelo.TipoModeloId))
                .OrderBy(modelo => modelo.Descricao).ThenBy(modelo => modelo.Id)
                .Select(modelo => new ResultadoPesquisaModeloRelatorioDTO { Id = modelo.Id, Descricao = modelo.Descricao, Ativo = modelo.Ativo }).ToList();
        }

        private static int[] TiposHistorico(JustDoTheWorkDbContext context)
            => context.TiposModelo.AsNoTracking().Select(tipo => new { tipo.Id, tipo.Descricao }).ToList()
                .Where(tipo => string.Concat(tipo.Descricao.Normalize(NormalizationForm.FormD).Where(letra => CharUnicodeInfo.GetUnicodeCategory(letra) != UnicodeCategory.NonSpacingMark)).Normalize(NormalizationForm.FormC).Trim().ToUpperInvariant()
                    is "HISTORICO EXECUCAO" or "HISTORICO DE EXECUCAO" or "HISTORICO DE EXECUCOES" or "HISTORICO EXECUCOES")
                .Select(tipo => tipo.Id).ToArray();
    }
}
