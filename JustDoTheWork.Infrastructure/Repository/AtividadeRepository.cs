using Dapper;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System.Text;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly DBConnection _dbConnection;

        public AtividadeRepository(DBConnection _dbConnection)
        {
            this._dbConnection = _dbConnection;
        }
        public string Inclusao(Atividade atividade)
        {
            const string sql = @"INSERT INTO Atividade(nome, descricao, status, datacriacao, datafinalizacao, projetoid)
                               VALUES(@Nome, @Descricao, @Status, @DataCriacao, @DataFinalizacao, @ProjetoId);";

            using (var connection = _dbConnection.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, atividade, transaction);
                            transaction.Commit();
                        }
                        catch(Exception ex)
                        {
                            transaction.Rollback();
                            return "Ocorreu um erro ao tentar realizar a ação de inclusão da atividade! " + ex.Message;
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

                                                                                  
        public string Edicao(Atividade atividade)
        {
            var sql = @"UPDATE ATIVIDADE SET nome = @Nome, descricao = @Descricao, status = @Status,
                      datafinalizacao = @DataFinalizacao, projetoid = @ProjetoId where id = @Id";

            using (var connection = _dbConnection.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, atividade, transaction);
                            transaction.Commit();
                        }
                        catch(Exception ex)
                        {
                            transaction.Rollback();
                            return "Ocorreu um erro ao tentar realizar a edição da atividade! " + ex.Message;
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
        public string ExclusaoPorId(int Id)
        {
            var sql = @"DELETE FROM atividade where id = @Id";

            using (var connection = _dbConnection.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, new { id = Id }, transaction);
                            transaction.Commit();
                        }
                        catch(Exception ex)
                        {
                            transaction.Rollback();
                            return "Ocorreu um erro ao tentar excluir a atividade! " + ex.Message;
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
        public Atividade BuscarPorId(int id)
        {
            const string sql = @"SELECT * FROM atividade WHERE id = @Id";

            using (var conn = _dbConnection.Create())
            {
                return conn.QueryFirstOrDefault<Atividade>(
                    sql,
                    new { Id = id }
                );
            }
        }
        public IEnumerable<AtualizaGridAtividadeDTO> PesquisarParaGrid(AtividadeFilter filtro)
        {
            var sql = new StringBuilder();
            sql.Append(@"SELECT a.id AS Id,
                         a.nome AS Atividade,
                         p.nome AS Projeto FROM atividade a
                         INNER JOIN projeto p ON a.projetoid = p.id WHERE 1 = 1");

            var parametros = new DynamicParameters();

            if (!string.IsNullOrWhiteSpace(filtro.Nome))
            {
                sql.Append(" AND a.nome LIKE @Nome ");
                parametros.Add("@Nome", $"%{filtro.Nome}%");
            }

            if (filtro.Status > 0)
            {
                sql.Append(" AND a.status = @Status ");
                parametros.Add("Status", filtro.Status);
            }

            if (filtro.ProjetoId > 0)
            {
                sql.Append(" AND a.projetoid = @ProjetoId ");
                parametros.Add("ProjetoId", filtro.ProjetoId);
            }

            if (filtro.DataCriacao.HasValue)
            {
                sql.Append(" AND a.datacriacao = @DataCriacao ");
                parametros.Add("DataCriacao", filtro.DataCriacao.Value.Date);
            }

            if (filtro.DataFinalizacao.HasValue)
            {
                sql.Append(" AND a.datafinalizacao = @DataFinalizacao ");
                parametros.Add("DataFinalizacao", filtro.DataFinalizacao.Value.Date);
            }

            using (var conn = _dbConnection.Create())
                return conn.Query<AtualizaGridAtividadeDTO>(sql.ToString(), parametros);
        }

        public IEnumerable<ResultadoPesquisaHistoricoDTO> PesquisarParaGridVisualizaHistorico(FiltroPesquisaHistoricoDTO filtro)
        {
            var sql = new StringBuilder();
            sql.Append(@"SELECT
                        a.nome AS NomeAtividade,
                        p.nome AS NomeProjeto,
                        e.DataInicio AS DataInicioExecucao,
                        e.DataFim AS DataFimExecucao
                        FROM atividade a
                        INNER JOIN projeto p ON a.projetoid = p.id
                        INNER JOIN execucao e ON a.Id = e.AtividadeId
                        WHERE 1 = 1");

            var parametros = new DynamicParameters();

            if (filtro.Status > 0)
            {
                sql.Append(" AND a.status = @Status ");
                parametros.Add("Status", filtro.Status);
            }

            if (filtro.ProjetoId > 0)
            {
                sql.Append(" AND a.projetoid = @ProjetoId ");
                parametros.Add("ProjetoId", filtro.ProjetoId);
            }

            if (filtro.DataCriacaoAtividade.HasValue)
            {
                sql.Append(" AND a.datacriacao = @DataCriacaoAtividade ");
                parametros.Add("DataCriacaoAtividade", filtro.DataCriacaoAtividade.Value.Date);
            }

            using (var conn = _dbConnection.Create())
                return conn.Query<ResultadoPesquisaHistoricoDTO>(sql.ToString(), parametros);
        }

        public IEnumerable<AtualizaAtividadesExecucaoDTO> BuscaParaGridAtividades(int Status)
        {
            var sql = @" select a.id as AtividadeId, a.nome as NomeAtividade, p.nome as NomeProjeto " +
                      " from atividade a " +
                      " inner join projeto p on p.id = a.projetoid " +
                      " where a.status = @Status";

            using (var conn = _dbConnection.Create())
            {
                return conn.Query<AtualizaAtividadesExecucaoDTO>(
                    sql.ToString(),
                    new {Status}
                );
            }
        }
        public string ExecutaAtividade(int Id, int Status)
        {
            var sql = @"UPDATE atividade 
                        SET status = @Status, 
                            datafinalizacao =
                                        CASE 
                                            WHEN @Status = 6 THEN @DataFinalizacao ELSE datafinalizacao 
                                        END 
                        WHERE id = @Id";

            using (var connection = _dbConnection.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, new { id = Id, status = Status, DataFinalizacao = DateTime.Now }, transaction);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return "Ocorreu um erro ao tentar realizar a execução desta atividade!" + ex.Message;
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

        
    }
}