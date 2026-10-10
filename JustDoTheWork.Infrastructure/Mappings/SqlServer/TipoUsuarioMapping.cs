using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.SqlServer
{
    public sealed class TipoUsuarioMapping : IEntityTypeConfiguration<TipoUsuario>
    {
        public void Configure(EntityTypeBuilder<TipoUsuario> builder)
        {
            builder.ToTable("TipoUsuario");

            builder.HasKey(tu => tu.Id);

            builder.Property(tu => tu.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(tu => tu.Tipo).HasColumnName("Tipo").HasMaxLength(50).IsUnicode(false).IsRequired();
        }
    }
}
