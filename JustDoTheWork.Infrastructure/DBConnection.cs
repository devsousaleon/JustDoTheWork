using Microsoft.Data.SqlClient;
using Npgsql;
using System.Data;

namespace JustDoTheWork.Infrastructure
{
    public class DBConnection
    {
        private readonly string _connectionString;
        private readonly DatabaseProvider _provider;

        public DBConnection(string connectionString)
            : this(connectionString, "Microsoft.Data.SqlClient")
        {
        }

        public DBConnection(string connectionString, string providerName)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
                throw new ArgumentException("A connection string não pode ser vazia.", nameof(connectionString));

            _connectionString = connectionString;
            _provider = DatabaseProviderResolver.Resolve(providerName);
        }

        public IDbConnection Create()
        {
            IDbConnection conn = _provider switch
            {
                DatabaseProvider.SqlServer => new SqlConnection(_connectionString),
                DatabaseProvider.Postgres => new NpgsqlConnection(_connectionString),
                _ => throw new NotSupportedException("O provider informado não é suportado.")
            };

            conn.Open();
            return conn;
        }
    }
}
