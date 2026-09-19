using Dapper;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;

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
            }
            catch (Exception exception)
            {
                return "Erro ao iniciar a execução! \n" + exception.Message;
            }

            return "";
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
            return null;
            //var sql = " SELECT " +
            //          " datainicio AS DataInicioExecucao, " +
            //          " datafim AS DataFimExecucao, " +
            //          " atividadeid AS AtividadeId FROM execucao " +                      
            //          " WHERE atividadeid = @AtividadeId";
            //using (var connection = _dbConnection.Create())
            //{
            //    return connection.Query<ExecucaoDTO>(sql.ToString(), new { AtividadeId });
            //}
        }
        public VisualizaExecucaoAtividadeDTO BuscaInfoAtividadeExecucao(int AtividadeId)
        {
            return null;
            //var sql = @"SELECT " +
            //          " a.nome AS NomeAtividade, " +
            //          " a.descricao AS DescricaoAtividade, " +
            //          " a.datacriacao AS DataCriacaoAtividade, " +
            //          " p.nome AS NomeProjeto FROM atividade a " +
            //          " INNER JOIN projeto p on p.id = a.projetoid " +
            //          " WHERE a.id = @AtividadeId";

            //using (var connection = _dbConnection.Create())
            //{
            //    return connection.QueryFirstOrDefault<VisualizaExecucaoAtividadeDTO>(sql.ToString(), new { AtividadeId });
            //}
        }
    }
}