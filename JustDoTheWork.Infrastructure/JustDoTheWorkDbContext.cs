using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using PostgresMappings = JustDoTheWork.Infrastructure.Mappings.Postgres;
using SqlServerMappings = JustDoTheWork.Infrastructure.Mappings.SqlServer;

namespace JustDoTheWork.Infrastructure;

public sealed class JustDoTheWorkDbContext : DbContext
{
    public JustDoTheWorkDbContext(DbContextOptions<JustDoTheWorkDbContext> options)
        : base(options)
    {
    }

    public DbSet<Atividade> Atividades => Set<Atividade>();
    public DbSet<Execucao> Execucoes => Set<Execucao>();
    public DbSet<Projeto> Projetos => Set<Projeto>();
    public DbSet<ModeloRelatorio> ModelosRelatorio => Set<ModeloRelatorio>();
    public DbSet<TipoModelo> TiposModelo => Set<TipoModelo>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        if (Database.IsSqlServer())
        {
            ApplySqlServerMappings(modelBuilder);
            return;
        }

        if (Database.IsNpgsql())
        {
            ApplyPostgresMappings(modelBuilder);
            return;
        }

        throw new InvalidOperationException(
            $"Não há mappings configurados para o provider '{Database.ProviderName}'.");
    }

    private static void ApplySqlServerMappings(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new SqlServerMappings.AtividadeMapping());
        modelBuilder.ApplyConfiguration(new SqlServerMappings.ExecucaoMapping());
        modelBuilder.ApplyConfiguration(new SqlServerMappings.ProjetoMapping());
        modelBuilder.ApplyConfiguration(new SqlServerMappings.ModeloRelatorioMapping());
        modelBuilder.ApplyConfiguration(new SqlServerMappings.TipoModeloMapping());
    }

    private static void ApplyPostgresMappings(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PostgresMappings.AtividadeMapping());
        modelBuilder.ApplyConfiguration(new PostgresMappings.ExecucaoMapping());
        modelBuilder.ApplyConfiguration(new PostgresMappings.ProjetoMapping());
        modelBuilder.ApplyConfiguration(new PostgresMappings.ModeloRelatorioMapping());
        modelBuilder.ApplyConfiguration(new PostgresMappings.TipoModeloMapping());
    }
}
