namespace JustDoTheWork.Infrastructure;

internal enum DatabaseProvider
{
    SqlServer,
    Postgres
}

internal static class DatabaseProviderResolver
{
    public static DatabaseProvider Resolve(string providerName)
    {
        if (string.IsNullOrWhiteSpace(providerName))
            throw new ArgumentException("O provider do banco de dados não pode ser vazio.", nameof(providerName));

        if (providerName.Equals("SqlServer", StringComparison.OrdinalIgnoreCase) ||
            providerName.Equals("System.Data.SqlClient", StringComparison.OrdinalIgnoreCase) ||
            providerName.Equals("Microsoft.Data.SqlClient", StringComparison.OrdinalIgnoreCase))
        {
            return DatabaseProvider.SqlServer;
        }

        if (providerName.Equals("Postgres", StringComparison.OrdinalIgnoreCase) ||
            providerName.Equals("PostgreSql", StringComparison.OrdinalIgnoreCase) ||
            providerName.Equals("Npgsql", StringComparison.OrdinalIgnoreCase) ||
            providerName.Equals("Npgsql.EntityFrameworkCore.PostgreSQL", StringComparison.OrdinalIgnoreCase))
        {
            return DatabaseProvider.Postgres;
        }

        throw new NotSupportedException($"O provider '{providerName}' não é suportado.");
    }
}
