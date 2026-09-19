using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure;

public sealed class JustDoTheWorkDbContextFactory : IDbContextFactory<JustDoTheWorkDbContext>
{
    private readonly DbContextOptions<JustDoTheWorkDbContext> _options;

    public JustDoTheWorkDbContextFactory(string connectionString, string providerName)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentException("A connection string não pode ser vazia.", nameof(connectionString));

        var optionsBuilder = new DbContextOptionsBuilder<JustDoTheWorkDbContext>();

        switch (DatabaseProviderResolver.Resolve(providerName))
        {
            case DatabaseProvider.SqlServer:
                optionsBuilder.UseSqlServer(connectionString);
                break;

            case DatabaseProvider.Postgres:
                optionsBuilder.UseNpgsql(connectionString);
                break;

            default:
                throw new NotSupportedException($"O provider '{providerName}' não é suportado.");
        }

        _options = optionsBuilder.Options;
    }

    public JustDoTheWorkDbContext CreateDbContext()
        => new(_options);
}
