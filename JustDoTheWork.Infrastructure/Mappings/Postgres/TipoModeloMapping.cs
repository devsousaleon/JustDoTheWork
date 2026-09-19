using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.Postgres;

public sealed class TipoModeloMapping : IEntityTypeConfiguration<TipoModelo>
{
    public void Configure(EntityTypeBuilder<TipoModelo> builder)
    {
        builder.ToTable("tipomodelo");

        builder.HasKey(tm => tm.Id);
        builder.Property(tm => tm.Id).HasColumnName("id").UseIdentityByDefaultColumn();
        builder.Property(tm => tm.Descricao).HasColumnName("descricao").HasMaxLength(50).IsRequired();
    }
}
