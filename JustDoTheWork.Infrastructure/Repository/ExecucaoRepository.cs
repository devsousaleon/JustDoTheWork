using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ExecucaoRepository : IExecucaoRepository
    {
        private readonly JustDoTheWorkDbContextFactory _dbContextFactory;

        public ExecucaoRepository(JustDoTheWorkDbContextFactory? dbContextFactory = null)
        {
            _dbContextFactory = dbContextFactory;
        }

        public string Inclusao(Execucao execucao, JustDoTheWorkDbContext context)
        {
            try
            {
                context.Execucoes.Add(execucao);
                context.SaveChanges();
                return "";
            }
            catch (Exception exception)
            {
                return "Erro ao iniciar a execução! \n" + exception.Message;
            }            
        }

        public string FinalizaExecucao(Execucao execucao, JustDoTheWorkDbContext context)
        {
            try
            {
                var execucaoSalva = context.Execucoes.FirstOrDefault(e => e.AtividadeId == execucao.AtividadeId && e.DataFim == null);
                execucaoSalva.DataFim = execucao.DataFim;
                context.SaveChanges();
                return "";
            }
            catch (Exception exception)
            {
                return "Erro ao finalizar/pausar a execução! \n" + exception.Message;
            }
        }

        public IEnumerable<ExecucaoDTO> BuscarPorExecucoesPorAtividadeId(int AtividadeId)
        {
            using var context = _dbContextFactory.CreateDbContext();
            return context.Execucoes.AsNoTracking()
                             .Where(e => e.AtividadeId == AtividadeId)
                             .Select(e => new ExecucaoDTO
                             {
                                 AtividadeId = e.AtividadeId,
                                 DataFim = e.DataFim,
                                 DataInicio = e.DataInicio
                             }).ToList();
        }
        public VisualizaExecucaoAtividadeDTO BuscaInfoAtividadeExecucao(int AtividadeId)
        {
            using var context = _dbContextFactory.CreateDbContext();

            return context.Atividades
                .AsNoTracking()
                .Where(a => a.Id == AtividadeId)
                .Join(
                    context.Projetos.AsNoTracking(),
                    a => a.ProjetoId,
                    p => p.Id,
                    (a, p) => new VisualizaExecucaoAtividadeDTO
                    {
                        NomeAtividade = a.Nome,
                        DescricaoAtividade = a.Descricao,
                        DataCriacaoAtividade = a.DataCriacao,
                        NomeProjeto = p.Nome
                    })
                .FirstOrDefault();
        }
    }
}
