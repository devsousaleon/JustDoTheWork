using Dapper;
using JustDoTheWork.Entity.DatabaseClasses;
using JustDoTheWork.Infrastructure.InterfaceRepository;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class TipoModeloRepository : ITipoModeloRepository
    {
        private readonly DBConnection _dbConnection;

        public TipoModeloRepository(DBConnection dbConnection)
        {
            _dbConnection = dbConnection;
        }

        IEnumerable<TipoModelo> ITipoModeloRepository.PesquisarParaCombo()
        {
            var sql = "SELECT * FROM TipoModelo";

            using var conn = _dbConnection.Create();
                return conn.Query<TipoModelo>(sql.ToString());
        }
    }
}