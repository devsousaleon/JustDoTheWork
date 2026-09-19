using JustDoTheWork.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.SqlServer;

public sealed class ProjetoMapping : IEntityTypeConfiguration<Projeto>
{
    public void Configure(EntityTypeBuilder<Projeto> builder)
    {
        builder.ToTable("Projeto");

        builder.HasKey(p => p.Id);
        builder.Property(p => p.Id).HasColumnName("Id").ValueGeneratedOnAdd();
        builder.Property(p => p.Nome).HasColumnName("Nome").HasMaxLength(50).IsUnicode(false).IsRequired();
    }
}
