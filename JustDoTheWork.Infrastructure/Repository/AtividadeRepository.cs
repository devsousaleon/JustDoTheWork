using Dapper;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class AtividadeRepository : IAtividadeRepository
    {
        private readonly DBConnectionFactory _factory;

        public AtividadeRepository(DBConnectionFactory factory)
        {
            _factory = factory;
        }
        public string Inclusao(Atividade atividade)
        {
            const string sql = @"INSERT INTO Atividade(nome, descricao, status, datacriacao, datafinalizacao, projetoid)
                               VALUES(@Nome, @Descricao, @Status, @DataCriacao, @DataFinalizacao, @ProjetoId);";

            using (var connection = _factory.Create())
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
                        catch
                        {
                            transaction.Rollback();
                            return "Ocorreu um erro ao tentar realizar a ação de inclusão da atividade!";
                        }
                    }
                }
                catch (Exception)
                {
                    return "Erro ao tentar conectar no banco de dados!";
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

            using (var connection = _factory.Create())
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
                        catch
                        {
                            transaction.Rollback();
                            return "Ocorreu um erro ao tentar realizar a edição da atividade!";
                        }

                    }
                }
                catch (Exception)
                {
                    return "Erro ao tentar conectar no banco de dados!";
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

            using (var connection = _factory.Create())
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
                        catch
                        {
                            transaction.Rollback();
                            return "Ocorreu um erro ao tentar excluir a atividade!";
                        }
                    }
                }
                catch (Exception)
                {
                    return "Erro ao tentar conectar no banco de dados!";
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

            using (var conn = _factory.Create())
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
                sql.Append(" AND a.nome ILIKE @Nome ");
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
                sql.Append(" AND a.datacriacao::date = @DataCriacao ");
                parametros.Add("DataCriacao", filtro.DataCriacao.Value.Date);
            }

            if (filtro.DataFinalizacao.HasValue)
            {
                sql.Append(" AND a.datafinalizacao::date = @DataFinalizacao ");
                parametros.Add("DataFinalizacao", filtro.DataFinalizacao.Value.Date);
            }

            using (var conn = _factory.Create())
            {
                return conn.Query<AtualizaGridAtividadeDTO>(
                    sql.ToString(),
                    parametros
                );
            }
        }

        public IEnumerable<AtualizaAtividadesExecucaoDTO> BuscaParaGridAtividades(int Status)
        {
            var sql = @" select a.id as AtividadeId, a.nome as NomeAtividade, p.nome as NomeProjeto " +
                      " from atividade a " +
                      " inner join projeto p on p.id = a.projetoid " +
                      " where a.status = @Status";

            using (var conn = _factory.Create())
            {
                return conn.Query<AtualizaAtividadesExecucaoDTO>(
                    sql.ToString(),
                    new {Status}
                );
            }
        }

        public string ExecutaAtividade(int Id, int Status)
        {
            var sql = @"UPDATE atividade set status = @Status where id = @Id";

            using (var connection = _factory.Create())
            {
                try
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, new { id = Id, status = Status }, transaction);
                            transaction.Commit();
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            return "Ocorreu um erro ao tentar realizar a execução desta atividade!" + ex;
                        }
                    }
                }
                catch (Exception ex)
                {
                    return "Erro ao conectar no banco de dados \n" + ex;
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
