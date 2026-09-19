using JustDoTheWork.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.Postgres;

public sealed class ProjetoMapping : IEntityTypeConfiguration<Projeto>
{
    public void Configure(EntityTypeBuilder<Projeto> builder)
    {
        builder.ToTable("projeto");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).HasColumnName("id").UseIdentityByDefaultColumn();
        builder.Property(p => p.Nome).HasColumnName("nome").HasMaxLength(50).IsRequired();
    }
}
