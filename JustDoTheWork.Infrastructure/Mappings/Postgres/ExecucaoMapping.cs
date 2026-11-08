using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
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
        builder.Property(e => e.DataInicio).HasColumnName("datainicio").HasColumnType("timestamp without time zone").IsRequired();
        builder.Property(e => e.DataFim).HasColumnName("datafim").HasColumnType("timestamp without time zone").IsRequired(false);
        builder.Property(e => e.AtividadeId).HasColumnName("atividadeid").IsRequired();
        
        builder.Property(e => e.UsuarioId).HasColumnName("usuarioid");
        builder.Property(e => e.Etapa).HasColumnName("etapa").HasConversion<int>();
        builder.HasOne<Usuario>().WithMany().HasForeignKey(e => e.UsuarioId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("fk_execucao_usuario");
        builder.HasIndex(e => new { e.AtividadeId, e.Etapa, e.DataFim });
        builder.HasIndex(e => e.AtividadeId).HasDatabaseName("ix_execucao_atividadeid");
        builder.HasOne<Atividade>().WithMany().HasForeignKey(e => e.AtividadeId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("fk_atividade_execucao");
    }
}
