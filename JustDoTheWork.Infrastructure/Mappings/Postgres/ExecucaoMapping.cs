using JustDoTheWork.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.Postgres;

public sealed class ExecucaoMapping : IEntityTypeConfiguration<Execucao>
{
    public void Configure(EntityTypeBuilder<Execucao> builder)
    {
        builder.ToTable("execucao");

        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id).HasColumnName("id").UseIdentityByDefaultColumn();
        builder.Property(e => e.DataInicio).HasColumnName("datainicio").IsRequired();
        builder.Property(e => e.DataFim).HasColumnName("datafim").IsRequired(false);
        builder.Property(e => e.AtividadeId).HasColumnName("atividadeid").IsRequired();
        
        builder.HasIndex(e => e.AtividadeId).HasDatabaseName("ix_execucao_atividadeid");
        builder.HasOne<Atividade>().WithMany().HasForeignKey(e => e.AtividadeId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("fk_atividade_execucao");
    }
}
