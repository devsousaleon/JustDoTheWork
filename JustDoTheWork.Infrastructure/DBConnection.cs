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
            //var conn = new NpgsqlConnection(_connectionString);
            var conn = new SqlConnection(_connectionString);
            conn.Open();
            return conn;
        }
    }
}