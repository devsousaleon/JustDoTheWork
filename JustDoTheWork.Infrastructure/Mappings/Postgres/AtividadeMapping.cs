using JustDoTheWork.Entity;
using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.Postgres;

public sealed class AtividadeMapping : IEntityTypeConfiguration<Atividade>
{
    public void Configure(EntityTypeBuilder<Atividade> builder)
    {
        builder.ToTable("atividade");

        builder.HasKey(a => a.Id);
        builder.Property(a => a.Id).HasColumnName("id").UseIdentityByDefaultColumn();
        builder.Property(a => a.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();
        builder.Property(a => a.Descricao).HasColumnName("descricao").IsRequired(false);
        builder.Property(a => a.Status).HasColumnName("status").HasConversion<int>().IsRequired();
        builder.Property(a => a.DataCriacao).HasColumnName("datacriacao").HasColumnType("timestamp without time zone").IsRequired();
        builder.Property(a => a.DataFinalizacao).HasColumnName("datafinalizacao").HasColumnType("timestamp without time zone").IsRequired(false);
        builder.Property(a => a.ProjetoId).HasColumnName("projetoid").IsRequired(false);
        
        builder.HasIndex(a => a.ProjetoId);
        builder.Property(a => a.Etapa).HasColumnName("etapa").HasConversion<int>().IsConcurrencyToken().IsRequired();
        builder.Property(a => a.UsuarioResponsavelId).HasColumnName("usuarioresponsavelid").IsConcurrencyToken();
        builder.Property(a => a.Status).IsConcurrencyToken();
        builder.Property(a => a.UltimoDesenvolvedorId).HasColumnName("ultimodesenvolvedorid").IsConcurrencyToken();
        builder.Property(a => a.RetornoExclusivo).HasColumnName("retornoexclusivo").IsConcurrencyToken();
        builder.HasOne<Usuario>().WithMany().HasForeignKey(a => a.UltimoDesenvolvedorId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("fk_atividade_ultimodesenvolvedor");
        builder.HasIndex(a => new { a.UsuarioResponsavelId, a.Status });
        builder.HasOne<Usuario>().WithMany().HasForeignKey(a => a.UsuarioResponsavelId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("fk_usuarioresponsavel_atividade");
        builder.HasIndex(a => a.Status);
        builder.HasOne<Projeto>().WithMany().HasForeignKey(atividade => atividade.ProjetoId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("fk_projeto_atividade");
    }
}
