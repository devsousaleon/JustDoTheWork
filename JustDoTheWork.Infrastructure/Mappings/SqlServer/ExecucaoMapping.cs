using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.SqlServer;

public sealed class ExecucaoMapping : IEntityTypeConfiguration<Execucao>
{
    public void Configure(EntityTypeBuilder<Execucao> builder)
    {
        builder.ToTable("Execucao");

        builder.HasKey(execucao => execucao.Id);

        builder.Property(execucao => execucao.Id).HasColumnName("Id").ValueGeneratedOnAdd();
        builder.Property(execucao => execucao.DataInicio).HasColumnName("DataInicio").IsRequired();
        builder.Property(execucao => execucao.DataFim).HasColumnName("DataFim").IsRequired(false);
        builder.Property(execucao => execucao.AtividadeId).HasColumnName("AtividadeId").IsRequired();

        builder.Property(execucao => execucao.UsuarioId).HasColumnName("UsuarioId");
        builder.Property(execucao => execucao.Etapa).HasColumnName("Etapa").HasConversion<int>();
        builder.HasOne<Usuario>().WithMany().HasForeignKey(execucao => execucao.UsuarioId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Execucao_Usuario");
        builder.HasIndex(execucao => new { execucao.AtividadeId, execucao.Etapa, execucao.DataFim });
        builder.HasIndex(execucao => execucao.AtividadeId);
        builder.HasOne<Atividade>().WithMany().HasForeignKey(execucao => execucao.AtividadeId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Atividade_Execucao");
    }
}
