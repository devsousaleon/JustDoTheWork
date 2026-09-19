using JustDoTheWork.Entity;
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
        builder.Property(a => a.DataCriacao).HasColumnName("datacriacao").IsRequired();
        builder.Property(a => a.DataFinalizacao).HasColumnName("datafinalizacao").IsRequired(false);
        builder.Property(a => a.ProjetoId).HasColumnName("projetoid").IsRequired();        
        
        builder.HasIndex(a => a.ProjetoId);
        builder.HasIndex(a => a.Status);
        builder.HasOne<Projeto>().WithMany().HasForeignKey(atividade => atividade.ProjetoId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("fk_projeto_atividade");
    }
}
