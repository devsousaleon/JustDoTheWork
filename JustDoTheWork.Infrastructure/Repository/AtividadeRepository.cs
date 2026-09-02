using Dapper;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System.Data;
using System.Text;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly DBConnection _dbConnection;

        public AtividadeRepository(DBConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Result Inclusao(Atividade atividade)
        {
            const string sql = @"INSERT INTO Atividade(nome, descricao, status, datacriacao, datafinalizacao, projetoid)
                               VALUES(@Nome, @Descricao, @Status, @DataCriacao, @DataFinalizacao, @ProjetoId);";

            try
            {
                using var uow = new UnitOfWork(_dbConnection);
                uow.Begin();
                uow.Connection.Execute(sql, atividade, uow.Transaction);
                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Erro ao incluir atividade.", ex);
            }
        }

        public Result Edicao(Atividade atividade)
        {
            const string sql = @"UPDATE Atividade SET nome = @Nome, descricao = @Descricao, status = @Status,
                      datafinalizacao = @DataFinalizacao, projetoid = @ProjetoId WHERE id = @Id";

            try
            {
                using var uow = new UnitOfWork(_dbConnection);
                uow.Begin();
                uow.Connection.Execute(sql, atividade, uow.Transaction);
                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Erro ao editar atividade.", ex);
            }
        }

        public Result ExclusaoPorId(int id)
        {
            const string sql = @"DELETE FROM Atividade WHERE id = @Id";

            try
            {
                using var uow = new UnitOfWork(_dbConnection);
                uow.Begin();
                uow.Connection.Execute(sql, new { Id = id }, uow.Transaction);
                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Erro ao excluir atividade.", ex);
            }
        }

        public Atividade BuscarPorId(int id)
        {
            const string sql = @"SELECT * FROM Atividade WHERE id = @Id";

            using var conn = _dbConnection.Create();
            return conn.QueryFirstOrDefault<Atividade>(sql, new { Id = id });
        }

        public IEnumerable<AtualizaGridAtividadeDTO> PesquisarParaGrid(AtividadeFilter filtro)
        {
            var sql = new StringBuilder();
            sql.Append(@"SELECT a.id AS Id, a.nome AS Atividade, p.nome AS Projeto
                         FROM Atividade a
                         INNER JOIN Projeto p ON a.projetoid = p.id WHERE 1 = 1");

            var parametros = new DynamicParameters();

            if (!string.IsNullOrWhiteSpace(filtro.Nome))
            {
                sql.Append(" AND a.nome LIKE @Nome");
                parametros.Add("Nome", $"%{filtro.Nome}%");
            }

            if (filtro.Status > 0)
            {
                sql.Append(" AND a.status = @Status");
                parametros.Add("Status", filtro.Status);
            }

            if (filtro.ProjetoId > 0)
            {
                sql.Append(" AND a.projetoid = @ProjetoId");
                parametros.Add("ProjetoId", filtro.ProjetoId);
            }

            if (filtro.DataCriacao.HasValue)
            {
                sql.Append(" AND a.datacriacao = @DataCriacao");
                parametros.Add("DataCriacao", filtro.DataCriacao.Value.Date);
            }

            if (filtro.DataFinalizacao.HasValue)
            {
                sql.Append(" AND a.datafinalizacao = @DataFinalizacao");
                parametros.Add("DataFinalizacao", filtro.DataFinalizacao.Value.Date);
            }

            using var conn = _dbConnection.Create();
            return conn.Query<AtualizaGridAtividadeDTO>(sql.ToString(), parametros);
        }

        public IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarParaGridVisualizaHistorico(FiltroPesquisaHistoricoDTO filtro)
        {
            var sql = new StringBuilder();
            sql.Append(@"SELECT a.nome AS NomeAtividade, p.nome AS NomeProjeto,
                        e.DataInicio AS DataInicioExecucao, e.DataFim AS DataFimExecucao,
                        DATEDIFF(SECOND, e.DataInicio, COALESCE(e.DataFim, GETDATE())) AS DuracaoSegundos
                        FROM Atividade a
                        INNER JOIN Projeto p ON a.projetoid = p.id
                        INNER JOIN Execucao e ON a.Id = e.AtividadeId
                        WHERE 1 = 1");

            var parametros = new DynamicParameters();

            if (filtro.Status > 0)
            {
                sql.Append(" AND a.status = @Status");
                parametros.Add("Status", filtro.Status);
            }

            if (filtro.ProjetoId > 0)
            {
                sql.Append(" AND a.projetoid = @ProjetoId");
                parametros.Add("ProjetoId", filtro.ProjetoId);
            }

            if (filtro.DataCriacaoAtividade.HasValue)
            {
                sql.Append(" AND a.datacriacao = @DataCriacaoAtividade");
                parametros.Add("DataCriacaoAtividade", filtro.DataCriacaoAtividade.Value.Date);
            }

            using var conn = _dbConnection.Create();
            return conn.Query<ResultadoPesquisaHistoricoDTO>(sql.ToString(), parametros);
        }

        public IEnumerable<AtualizaAtividadesExecucaoDTO> BuscaParaGridAtividades(StatusAtividade status)
        {
            const string sql = @"SELECT a.id AS AtividadeId, a.nome AS NomeAtividade, p.nome AS NomeProjeto
                                 FROM Atividade a
                                 INNER JOIN Projeto p ON p.id = a.projetoid
                                 WHERE a.status = @Status";

            using var conn = _dbConnection.Create();
            return conn.Query<AtualizaAtividadesExecucaoDTO>(sql, new { Status = (int)status });
        }

        public IEnumerable<DashboardProjetoTempoDTO> BuscarTempoPorProjetoNoDia(DateTime dia)
        {
            var (inicio, fim) = FiltroDataDia.Intervalo(dia);

            const string sql = @"SELECT p.nome AS NomeProjeto,
                                 SUM(DATEDIFF(SECOND, e.datainicio, COALESCE(e.datafim, GETDATE()))) AS SegundosExecucao
                                 FROM Projeto p
                                 INNER JOIN Atividade a ON a.projetoid = p.id
                                 INNER JOIN Execucao e ON e.atividadeid = a.id
                                 WHERE e.datainicio >= @Inicio AND e.datainicio < @Fim
                                 GROUP BY p.nome";

            using var conn = _dbConnection.Create();
            return conn.Query<DashboardProjetoTempoDTO>(sql, new { Inicio = inicio, Fim = fim });
        }

        public DashboardDiaDTO BuscarResumoDia(DateTime dia)
        {
            var (inicio, fim) = FiltroDataDia.Intervalo(dia);

            const string sql = @"SELECT
                                 (SELECT COUNT(DISTINCT a.id) FROM Atividade a
                                  INNER JOIN Execucao e ON e.atividadeid = a.id
                                  WHERE a.status = @StatusFinalizado
                                  AND e.datafim >= @Inicio AND e.datafim < @Fim) AS AtividadesFinalizadas,
                                 (SELECT SUM(DATEDIFF(SECOND, e.datainicio, COALESCE(e.datafim, GETDATE())))
                                  FROM Execucao e
                                  WHERE e.datainicio >= @Inicio AND e.datainicio < @Fim) AS SegundosEmExecucao,
                                 (SELECT COUNT(*) FROM Execucao e
                                  WHERE e.datainicio >= @Inicio AND e.datainicio < @Fim) AS IntervalosFechados";

            using var conn = _dbConnection.Create();
            return conn.QueryFirstOrDefault<DashboardDiaDTO>(sql, new
            {
                StatusFinalizado = (int)StatusAtividade.Finalizado,
                Inicio = inicio,
                Fim = fim
            });
        }

        public int? BuscarAtividadeEmExecucaoExceto(int atividadeId, IDbTransaction transacao)
        {
            const string sql = @"SELECT TOP 1 id FROM Atividade
                                 WHERE status = @Status AND id <> @AtividadeId";

            return transacao.Connection!.QueryFirstOrDefault<int?>(sql, new
            {
                Status = (int)StatusAtividade.Executando,
                AtividadeId = atividadeId
            }, transacao);
        }

        public void AlterarStatus(int id, StatusAtividade status, DateTime? dataFinalizacao, IDbTransaction transacao)
        {
            const string sql = @"UPDATE Atividade SET status = @Status, datafinalizacao = @DataFinalizacao WHERE id = @Id";

            transacao.Connection!.Execute(sql, new
            {
                Id = id,
                Status = (int)status,
                DataFinalizacao = dataFinalizacao
            }, transacao);
        }
    }
}
