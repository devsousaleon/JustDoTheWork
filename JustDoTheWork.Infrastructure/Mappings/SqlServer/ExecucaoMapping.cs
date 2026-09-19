using JustDoTheWork.Entity;
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

        builder.HasIndex(execucao => execucao.AtividadeId);
        builder.HasOne<Atividade>().WithMany().HasForeignKey(execucao => execucao.AtividadeId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Atividade_Execucao");
    }
}
