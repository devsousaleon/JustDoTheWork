using Microsoft.EntityFrameworkCore;

namespace JustDoTheWork.Infrastructure;

public sealed class JustDoTheWorkDbContextFactory : IDbContextFactory<JustDoTheWorkDbContext>
{
    private readonly Lazy<DbContextOptions<JustDoTheWorkDbContext>> _options;

    public JustDoTheWorkDbContextFactory(string connectionString, string providerName)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
            throw new ArgumentException("A connection string não pode ser vazia.", nameof(connectionString));

        var provider = DatabaseProviderResolver.Resolve(providerName);
        _options = new Lazy<DbContextOptions<JustDoTheWorkDbContext>>(() => CriarOpcoes(connectionString, provider));
    }

    private static DbContextOptions<JustDoTheWorkDbContext> CriarOpcoes(string connectionString, DatabaseProvider provider)
    {
        var optionsBuilder = new DbContextOptionsBuilder<JustDoTheWorkDbContext>();

        switch (provider)
        {
            case DatabaseProvider.SqlServer:
                optionsBuilder.UseSqlServer(connectionString);
                break;

            case DatabaseProvider.Postgres:
                optionsBuilder.UseNpgsql(connectionString);
                break;

            default:
                throw new NotSupportedException($"O provider '{provider}' não é suportado.");
        }

        return optionsBuilder.Options;
    }

    public JustDoTheWorkDbContext CreateDbContext()
        => new(_options.Value);
}
