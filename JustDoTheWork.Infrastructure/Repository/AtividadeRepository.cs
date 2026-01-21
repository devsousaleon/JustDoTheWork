using Dapper;
using DevExpress.XtraEditors;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

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
                    connection.Open();
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
        public string ExclusaoPorId(int id)
        {
            var sql = @"DELETE FROM atividade where id = @Id";

            using (var connection = _factory.Create())
            {
                try
                {
                    connection.Open();
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, id, transaction);
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

        public IEnumerable<Atividade> Pesquisar(AtividadeFilter filtro)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT * FROM atividade WHERE 1 = 1 ");

            var parametros = new DynamicParameters();

            if (!string.IsNullOrWhiteSpace(filtro.Nome))
            {
                sql.Append("AND nome ILIKE @Nome ");
                parametros.Add("Nome", $"%{filtro.Nome}%");
            }

            if (filtro.Status > 0)
            {
                sql.Append("AND status = @Status ");
                parametros.Add("Status", filtro.Status);
            }

            if (filtro.ProjetoId > 0)
            {
                sql.Append("AND projetoid = @ProjetoId ");
                parametros.Add("ProjetoId", filtro.ProjetoId);
            }

            if (filtro.DataCriacao.HasValue)
            {
                sql.Append("AND datacriacao::date = @DataCriacao ");
                parametros.Add("DataCriacao", filtro.DataCriacao.Value.Date);
            }

            if (filtro.DataFinalizacao.HasValue)
            {
                sql.Append("AND datafinalizacao::date = @DataFinalizacao ");
                parametros.Add("DataFinalizacao", filtro.DataFinalizacao.Value.Date);
            }

            using (var conn = _factory.Create())
            {
                return conn.Query<Atividade>(
                    sql.ToString(),
                    parametros
                );
            }
        }
    }
}
