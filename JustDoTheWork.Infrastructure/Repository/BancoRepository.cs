using JustDoTheWork.DTO;
using Microsoft.Data.SqlClient;
using Npgsql;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class BancoRepository
    {
        public string TestarConexaoSqlServer(BancoDTO bancoConexao)
        {
            var connectionStringBuilder = new SqlConnectionStringBuilder
            {
                DataSource = bancoConexao.Servidor,
                InitialCatalog = bancoConexao.Banco,
                UserID = bancoConexao.Usuario,
                Password = bancoConexao.Senha,
                TrustServerCertificate = true,
                ConnectTimeout = 5
            };

            try
            {
                using var connection = new SqlConnection(connectionStringBuilder.ConnectionString);

                connection.Open();
                connection.Close();

                return "";
            }
            catch (SqlException exception)
            {
                return $"Não foi possível conectar ao SQL Server.\n{exception.Message}";
            }
            catch (Exception exception)
            {
                return $"Ocorreu um erro ao testar a conexão.\n{exception.Message}";
            }
        }

        public string TestarConexaoPostgres(BancoDTO bancoConexao)
        {
            var connectionStringBuilder = new NpgsqlConnectionStringBuilder
            {
                Host = bancoConexao.Servidor,
                Database = bancoConexao.Banco,
                Username = bancoConexao.Usuario,
                Password = bancoConexao.Senha,
                Timeout = 5
            };

            try
            {
                using var connection = new NpgsqlConnection(connectionStringBuilder.ConnectionString);

                connection.Open();
                connection.Close();

                return "";
            }
            catch (NpgsqlException exception)
            {
                return $"Não foi possível conectar ao PostgreSQL.\n{exception.Message}";
            }
            catch (Exception exception)
            {
                return $"Ocorreu um erro ao testar a conexão.\n{exception.Message}";
            }
        }
    }
}
