using Dapper;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System.Data;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ExecucaoRepository : IExecucaoRepository
    {
        private readonly DBConnection _dbConnection;

        public ExecucaoRepository(DBConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Result Inclusao(Execucao execucao)
        {
            const string sql = @"INSERT INTO Execucao(datainicio, datafim, atividadeid)
                               VALUES(@DataInicio, @DataFim, @AtividadeId)";

            try
            {
                using var uow = new UnitOfWork(_dbConnection);
                uow.Begin();
                uow.Connection.Execute(sql, execucao, uow.Transaction);
                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Erro ao iniciar execução.", ex);
            }
        }

        public Result FinalizaExecucao(Execucao execucao)
        {
            const string sql = @"UPDATE Execucao SET datafim = @DataFim
                               WHERE atividadeid = @AtividadeId AND datafim IS NULL";

            try
            {
                using var uow = new UnitOfWork(_dbConnection);
                uow.Begin();
                uow.Connection.Execute(sql, execucao, uow.Transaction);
                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Erro ao finalizar execução.", ex);
            }
        }

        public IEnumerable<ExecucaoDTO> BuscarPorExecucoesPorAtividadeId(int atividadeId)
        {
            const string sql = @"SELECT datainicio AS DataInicioExecucao, datafim AS DataFimExecucao,
                               atividadeid AS AtividadeId FROM Execucao
                               WHERE atividadeid = @AtividadeId";

            using var conn = _dbConnection.Create();
            return conn.Query<ExecucaoDTO>(sql, new { AtividadeId = atividadeId });
        }

        public VisualizaExecucaoAtividadeDTO BuscaInfoAtividadeExecucao(int atividadeId)
        {
            const string sql = @"SELECT a.nome AS NomeAtividade, a.descricao AS DescricaoAtividade,
                               a.datacriacao AS DataCriacaoAtividade, p.nome AS NomeProjeto
                               FROM Atividade a
                               INNER JOIN Projeto p ON p.id = a.projetoid
                               WHERE a.id = @AtividadeId";

            using var conn = _dbConnection.Create();
            return conn.QueryFirstOrDefault<VisualizaExecucaoAtividadeDTO>(sql, new { AtividadeId = atividadeId });
        }

        public bool ExisteExecucaoAberta(int atividadeId, IDbTransaction transacao)
        {
            const string sql = @"SELECT COUNT(1) FROM Execucao
                               WHERE atividadeid = @AtividadeId AND datafim IS NULL";

            return transacao.Connection!.ExecuteScalar<int>(sql, new { AtividadeId = atividadeId }, transacao) > 0;
        }

        public void Incluir(Execucao execucao, IDbTransaction transacao)
        {
            const string sql = @"INSERT INTO Execucao(datainicio, datafim, atividadeid)
                               VALUES(@DataInicio, @DataFim, @AtividadeId)";

            transacao.Connection!.Execute(sql, execucao, transacao);
        }

        public void FinalizarAberta(int atividadeId, DateTime dataFim, IDbTransaction transacao)
        {
            const string sql = @"UPDATE Execucao SET datafim = @DataFim
                               WHERE atividadeid = @AtividadeId AND datafim IS NULL";

            transacao.Connection!.Execute(sql, new { AtividadeId = atividadeId, DataFim = dataFim }, transacao);
        }
    }
}
