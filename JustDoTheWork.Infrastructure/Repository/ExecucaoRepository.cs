using Dapper;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ExecucaoRepository : IExecucaoRepository
    {
        private readonly DBConnection _dbConnection;

        public ExecucaoRepository(DBConnection _dbConnection)
        {
            this._dbConnection = _dbConnection;
        }
        public string Inclusao(Execucao execucao)
        {
            var sql = @"INSERT INTO execucao(datainicio, datafim, atividadeid)
                      VALUES(@DataInicio, @DataFim, @AtividadeId)";

            using (var connection = _dbConnection.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, execucao, transaction);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return "Erro ao iniciar a execução! \n" + ex.Message;
                        }
                    }
                }
                catch (Exception exception)
                {
                    return "Erro de conexão com banco de dados. " + exception.Message;
                }
                finally
                {
                    connection.Dispose();
                }
            }
            return "";
        }
        public string FinalizaExecucao(Execucao execucao)
        {
            var sql = @"UPDATE execucao SET datafim = @DataFim WHERE atividadeid = @AtividadeId AND datafim IS NULL";

            using (var connection = _dbConnection.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, execucao, transaction);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return "Erro ao pausar a execução! \n" + ex.Message;
                        }
                    }
                }
                catch (Exception exception)
                {
                    return "Erro de conexão com banco de dados. " + exception.Message;
                }
                finally
                {
                    connection.Dispose();
                }
            }
            return "";
        }
        public IEnumerable<ExecucaoDTO> BuscarPorExecucoesPorAtividadeId(int AtividadeId)
        {
            var sql = " SELECT " +
                      " datainicio AS DataInicioExecucao, " +
                      " datafim AS DataFimExecucao, " +
                      " atividadeid AS AtividadeId FROM execucao " +                      
                      " WHERE atividadeid = @AtividadeId";
            using (var connection = _dbConnection.Create())
            {
                return connection.Query<ExecucaoDTO>(sql.ToString(), new { AtividadeId });
            }
        }
        public VisualizaExecucaoAtividadeDTO BuscaInfoAtividadeExecucao(int AtividadeId)
        {
            var sql = @"SELECT " +
                      " a.nome AS NomeAtividade, " +
                      " a.descricao AS DescricaoAtividade, " +
                      " a.datacriacao AS DataCriacaoAtividade, " +
                      " p.nome AS NomeProjeto FROM atividade a " +
                      " INNER JOIN projeto p on p.id = a.projetoid " +
                      " WHERE a.id = @AtividadeId";

            using (var connection = _dbConnection.Create())
            {
                return connection.QueryFirstOrDefault<VisualizaExecucaoAtividadeDTO>(sql.ToString(), new { AtividadeId });
            }
        }
    }
}