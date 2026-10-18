using JustDoTheWork.DTO;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ModeloRelatorioRepository : IModeloRelatorioRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;

        public ModeloRelatorioRepository(JustDoTheWorkDbContextFactory? dbContextFactory = null)
        {
            _dbContextFactory = dbContextFactory;
        }

        public string Inclusao(ModeloRelatorio modeloRelatorio)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
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

        public string Edicao(ModeloRelatorio modeloRelatorio)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                var modeloExistente = context.ModelosRelatorio.Find(modeloRelatorio.Id)!;

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

        public string ExclusaoPorId(int id)
        {
            using var context = _dbContextFactory.CreateDbContext();
            using var transacao = context.Database.BeginTransaction();
            try
            {
                var modelosRelatorio = context.ModelosRelatorio.Find(id)!;
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
            using var context = _dbContextFactory.CreateDbContext();
            return context.ModelosRelatorio
                          .AsNoTracking()
                          .Where(mr => mr.Id == id)
                          .Select(mr => new ModeloRelatorioDTO
                          { 
                              Descricao = mr.Descricao,
                              Texto = mr.Texto,
                              Ativo = mr.Ativo,
                              TipoModeloId = mr.TipoModeloId
                          }).FirstOrDefault();
        }

        public byte[]? BuscarModeloHistoricoExecucao()
        {
            using var context = _dbContextFactory.CreateDbContext();

            return context.ModelosRelatorio
                          .AsNoTracking()
                          .Where(mr => mr.Ativo && mr.TipoModeloId == 1)
                          .Select(mr => mr.Texto)
                          .FirstOrDefault();
        }

        public DadosImpressaoHistoricoDTO? BuscarDadosImpressaoHistorico(IReadOnlyCollection<int> execucaoIds, int? usuarioId)
        {
            using var context = _dbContextFactory.CreateDbContext();

            var dados = (
                from modelo in context.ModelosRelatorio.AsNoTracking()
                join tipo in context.TiposModelo.AsNoTracking() on modelo.TipoModeloId equals tipo.Id
                where modelo.Ativo && modelo.TipoModeloId == 1
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
                join atividade in context.Atividades.AsNoTracking() on execucao.AtividadeId equals atividade.Id
                join projeto in context.Projetos.AsNoTracking() on atividade.ProjetoId equals projeto.Id
                where execucaoIds.Contains(execucao.Id)
                select new RegistroImpressaoHistoricoDTO
                {
                    Execucao = new ExecucaoDTO
                    {
                        Id = execucao.Id,
                        AtividadeId = execucao.AtividadeId,
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
                        ProjetoId = atividade.ProjetoId
                    },
                    Projeto = new ProjetoDTO { Id = projeto.Id, Nome = projeto.Nome }
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

            return dados;
        }

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtroPesquisaModeloRelatorioDTO)
        {
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
    }
}
