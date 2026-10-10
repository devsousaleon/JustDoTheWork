using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.Postgres;

public sealed class TipoUsuarioMapping : IEntityTypeConfiguration<TipoUsuario>
{
    public void Configure(EntityTypeBuilder<TipoUsuario> builder)
    {
        builder.ToTable("tipousuario");

        builder.HasKey(tu => tu.Id);
        builder.Property(tu => tu.Id).HasColumnName("id").UseIdentityByDefaultColumn();
        builder.Property(tu => tu.Tipo).HasColumnName("tipo").HasMaxLength(50).IsRequired();
    }
}
