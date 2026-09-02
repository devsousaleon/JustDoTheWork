using Dapper;
using JustDoTheWork.DTO;
using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;
using System.Text;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class ModeloRelatorioRepository : IModeloRelatorioRepository
    {
        private readonly DBConnection _dbConnection;

        public ModeloRelatorioRepository(DBConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        public Result Inclusao(ModeloRelatorio modelo)
        {
            const string sql = @"INSERT INTO ModeloRelatorio(descricao, tipomodeloid, texto, ativo)
                               VALUES(@Descricao, @TipoModeloId, @Texto, @Ativo)";

            try
            {
                using var uow = new UnitOfWork(_dbConnection);
                uow.Begin();
                uow.Connection.Execute(sql, modelo, uow.Transaction);
                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Erro ao incluir modelo de relatório.", ex);
            }
        }

        public Result Edicao(ModeloRelatorio modelo)
        {
            const string sql = @"UPDATE ModeloRelatorio SET Descricao = @Descricao, TipoModeloId = @TipoModeloId,
                               Texto = @Texto, Ativo = @Ativo WHERE Id = @Id";

            try
            {
                using var uow = new UnitOfWork(_dbConnection);
                uow.Begin();
                uow.Connection.Execute(sql, modelo, uow.Transaction);
                uow.Commit();
                return Result.Ok();
            }
            catch (Exception ex)
            {
                return Result.Falha("Erro ao editar modelo de relatório.", ex);
            }
        }

        public Result ExclusaoPorId(int id)
        {
            const string sql = @"DELETE FROM ModeloRelatorio WHERE Id = @Id";

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
                return Result.Falha("Erro ao excluir modelo de relatório.", ex);
            }
        }

        public ModeloRelatorioDTO BuscarPorId(int id)
        {
            const string sql = @"SELECT * FROM ModeloRelatorio WHERE id = @Id";

            using var conn = _dbConnection.Create();
            return conn.QueryFirstOrDefault<ModeloRelatorioDTO>(sql, new { Id = id });
        }

        public byte[]? BuscaModeloHistoricoExecucao()
        {
            const string sql = @"SELECT Texto FROM ModeloRelatorio WHERE TipoModeloId = 1 AND Ativo = 1";

            using var conn = _dbConnection.Create();
            return conn.QueryFirstOrDefault<byte[]>(sql);
        }

        public IEnumerable<ResultadoPesquisaModeloRelatorioDTO> Pesquisar(FiltroPesquisaModeloRelatorioDTO filtro)
        {
            var sql = new StringBuilder();
            sql.Append(@"SELECT mr.Id, mr.Descricao, tm.Descricao AS TipoModelo, mr.Ativo
                        FROM ModeloRelatorio mr
                        INNER JOIN TipoModelo tm ON tm.Id = mr.TipoModeloId
                        WHERE 1 = 1");

            var parametros = new DynamicParameters();

            if (!string.IsNullOrEmpty(filtro.DescricaoModelo))
            {
                sql.Append(" AND mr.Descricao LIKE @DescricaoModelo");
                parametros.Add("DescricaoModelo", $"%{filtro.DescricaoModelo.Trim()}%");
            }

            if (filtro.TipoModelo > 0)
            {
                sql.Append(" AND mr.TipoModeloId = @TipoModelo");
                parametros.Add("TipoModelo", filtro.TipoModelo);
            }

            using var conn = _dbConnection.Create();
            return conn.Query<ResultadoPesquisaModeloRelatorioDTO>(sql.ToString(), parametros);
        }
    }
}
