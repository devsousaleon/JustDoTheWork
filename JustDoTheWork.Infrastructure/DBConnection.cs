using Microsoft.Data.SqlClient;
using Npgsql;
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
            var connection = EhPostgres(_connectionString)
                ? (IDbConnection)new NpgsqlConnection(_connectionString)
                : new SqlConnection(_connectionString);

            connection.Open();
            return connection;
        }

        private static bool EhPostgres(string connectionString)
            => connectionString.IndexOf("Host=", StringComparison.OrdinalIgnoreCase) >= 0;
    }
}