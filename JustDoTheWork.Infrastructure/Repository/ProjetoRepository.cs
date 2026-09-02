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

        public ProjetoRepository(DBConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Result Inclusao(Projeto projeto)
        {
            const string sql = @"INSERT INTO Projeto(nome) VALUES(@Nome)";

            try
            {
                using var uow = new UnitOfWork(_dbConnection);
                uow.Begin();
                uow.Connection.Execute(sql, projeto, uow.Transaction);
                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Erro ao incluir projeto.", ex);
            }
        }

        public Result Edicao(Projeto projeto)
        {
            const string sql = @"UPDATE Projeto SET nome = @Nome WHERE id = @Id";

            try
            {
                using var uow = new UnitOfWork(_dbConnection);
                uow.Begin();
                uow.Connection.Execute(sql, projeto, uow.Transaction);
                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Erro ao editar projeto.", ex);
            }
        }

        public Result ExclusaoPorId(int id)
        {
            const string sql = @"DELETE FROM Projeto WHERE id = @Id";

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
                return Result.Falha("Erro ao excluir projeto.", ex);
            }
        }

        public Projeto BuscarPorId(int id)
        {
            const string sql = @"SELECT * FROM Projeto WHERE id = @Id";

            using var conn = _dbConnection.Create();
            return conn.QueryFirstOrDefault<Projeto>(sql, new { Id = id });
        }

        public IEnumerable<Projeto> Pesquisar(ProjetoFilter filtro)
        {
            var sql = new StringBuilder("SELECT * FROM Projeto WHERE 1 = 1");
            var parametros = new DynamicParameters();

            if (!string.IsNullOrWhiteSpace(filtro.Nome))
            {
                sql.Append(" AND nome LIKE @Nome");
                parametros.Add("Nome", $"%{filtro.Nome}%");
            }

            using var conn = _dbConnection.Create();
            return conn.Query<Projeto>(sql.ToString(), parametros);
        }
    }
}
