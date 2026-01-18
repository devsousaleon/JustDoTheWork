using Npgsql;
using Dapper;
using System.Data;

namespace JustDoTheWork.Infrastructure
{
    public class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection Create()
        {
            return new NpgsqlConnection(_connectionString);
        }
    }
}
