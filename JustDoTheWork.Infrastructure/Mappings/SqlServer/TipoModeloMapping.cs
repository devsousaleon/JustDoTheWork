using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.SqlServer;

public sealed class TipoModeloMapping : IEntityTypeConfiguration<TipoModelo>
{
    public void Configure(EntityTypeBuilder<TipoModelo> builder)
    {
        builder.ToTable("TipoModelo");

        builder.HasKey(tm => tm.Id);
        builder.Property(tm => tm.Id).HasColumnName("Id").ValueGeneratedOnAdd();
        builder.Property(tm => tm.Descricao).HasColumnName("Descricao").HasMaxLength(50).IsUnicode(false).IsRequired();
    }
}
