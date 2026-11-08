using JustDoTheWork.DTO;
using Microsoft.Data.SqlClient;
using Npgsql;
using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure.Repository
{
    public class BancoRepository
    {
        public void AtualizarEstruturaAtividades(JustDoTheWorkDbContextFactory factory)
        {
            using var context = factory.CreateDbContext();
            var nomeScript = context.Database.IsSqlServer() ? "AtualizarFluxoSqlServer.sql" : "AtualizarFluxoPostgres.sql";
            using var arquivo = typeof(BancoRepository).Assembly.GetManifestResourceStream("JustDoTheWork.Infrastructure.Scripts." + nomeScript)
                ?? throw new InvalidOperationException("Script de atualização do fluxo não encontrado.");
            using var leitor = new StreamReader(arquivo);
            using var transacao = context.Database.BeginTransaction();
            context.Database.ExecuteSqlRaw(leitor.ReadToEnd());
            transacao.Commit();
        }

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
