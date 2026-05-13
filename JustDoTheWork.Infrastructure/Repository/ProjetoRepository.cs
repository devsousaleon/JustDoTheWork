using Dapper;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.Domains;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System.Text;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ProjetoRepository : IProjetoRepository
    {
        private readonly DBConnection _dbConnection;

        public ProjetoRepository(DBConnection _dbConnection)
        {
            this._dbConnection = _dbConnection;
        }
        public string Inclusao(Projeto projeto)
        {
            var sql = @"INSERT INTO projeto(nome) VALUES(@Nome)";
            try
            {
                using (var connection = _dbConnection.Create())
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, projeto, transaction);
                            transaction.Commit();
                        }
                        catch(Exception ex)
                        {
                            transaction.Rollback();
                            return "Erro ao incluir projeto! " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                return "Erro de conexão com banco de dados. " + exception.Message;
            }

            return "";
        }
        public string Edicao(Projeto projeto)
        {
            var sql = @"UPDATE projeto SET nome = @nome WHERE id = @Id";
            try
            {
                using (var connection = _dbConnection.Create())
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, projeto, transaction);
                            transaction.Commit();
                        }
                        catch(Exception ex)
                        {
                            transaction.Rollback();
                            return "Erro ao editar dados do projeto! " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                return "Erro de conexão com banco de dados. " + exception.Message;
            }
            return "";
        }
        public string ExclusaoPorId(int id)
        {
            var sql = @"DELETE FROM projeto WHERE id = @Id";

            try
            {
                using (var connection = _dbConnection.Create())
                {
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            connection.Execute(sql, new { Id = id }, transaction);
                            transaction.Commit();
                        }
                        catch(Exception ex)
                        {
                            transaction.Rollback();
                            return "Erro ao excluir projeto! " + ex.Message;
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                return "Erro de conexão com banco de dados. " + exception.Message;
            }
            return "";
        }
        public Projeto BuscarPorId(int id)
        {
            var sql = @"SELECT * FROM projeto WHERE id = @Id";

            using (var connection = _dbConnection.Create())
            {
                return connection.QueryFirstOrDefault<Projeto>(
                    sql,
                    new { Id = id }
                );
            }
        }
        public IEnumerable<Projeto> Pesquisar(ProjetoFilter filtro)
        {
            var sql = new StringBuilder();
            sql.Append("SELECT * FROM projeto WHERE 1 = 1 ");

            var parametros = new DynamicParameters();

            if (!string.IsNullOrWhiteSpace(filtro.Nome))
            {
                sql.Append("AND nome ILIKE @Nome ");
                parametros.Add("Nome", $"%{filtro.Nome}%");
            }

            using (var conn = _dbConnection.Create())
            {
                return conn.Query<Projeto>(
                    sql.ToString(),
                    parametros
                );
            }
        }
    }
}
