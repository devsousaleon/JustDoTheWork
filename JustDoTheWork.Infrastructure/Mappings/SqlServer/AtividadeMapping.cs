using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.SqlServer;

public sealed class AtividadeMapping : IEntityTypeConfiguration<Atividade>
{
    public void Configure(EntityTypeBuilder<Atividade> builder)
    {
        builder.ToTable("Atividade");

        builder.HasKey(atividade => atividade.Id);

        builder.Property(atividade => atividade.Id).HasColumnName("Id").ValueGeneratedOnAdd();
        builder.Property(atividade => atividade.Nome).HasColumnName("Nome").HasMaxLength(50).IsUnicode(false).IsRequired();
        builder.Property(atividade => atividade.Descricao).HasColumnName("Descricao").IsRequired(false);
        builder.Property(atividade => atividade.Status).HasColumnName("Status").HasConversion<int>().IsRequired();
        builder.Property(atividade => atividade.DataCriacao).HasColumnName("DataCriacao").IsRequired();
        builder.Property(atividade => atividade.DataFinalizacao).HasColumnName("DataFinalizacao").IsRequired(false);
        builder.Property(atividade => atividade.ProjetoId).HasColumnName("ProjetoId").IsRequired(false);
        builder.Property(atividade => atividade.Etapa).HasColumnName("Etapa").HasConversion<int>().IsConcurrencyToken().IsRequired();
        builder.Property(atividade => atividade.UsuarioResponsavelId).HasColumnName("UsuarioResponsavelId").IsConcurrencyToken();
        builder.Property(atividade => atividade.Status).IsConcurrencyToken();
        builder.Property(atividade => atividade.UltimoDesenvolvedorId).HasColumnName("UltimoDesenvolvedorId").IsConcurrencyToken();
        builder.Property(atividade => atividade.RetornoExclusivo).HasColumnName("RetornoExclusivo").IsConcurrencyToken();
        builder.HasOne<Usuario>().WithMany().HasForeignKey(atividade => atividade.UltimoDesenvolvedorId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Atividade_UltimoDesenvolvedor");

        builder.HasIndex(atividade => atividade.ProjetoId);
        builder.HasIndex(atividade => atividade.Status);
        builder.HasIndex(atividade => new { atividade.UsuarioResponsavelId, atividade.Status });
        builder.HasOne<Usuario>().WithMany().HasForeignKey(atividade => atividade.UsuarioResponsavelId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_UsuarioResponsavel_Atividade");
        builder.HasOne<Projeto>().WithMany().HasForeignKey(atividade => atividade.ProjetoId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_Projeto_Atividade");
    }
}
