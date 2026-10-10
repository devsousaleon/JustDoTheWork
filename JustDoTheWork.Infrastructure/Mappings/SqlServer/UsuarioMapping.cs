using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.SqlServer
{
    public sealed class UsuarioMapping : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(u => u.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(30);
            builder.Property(u => u.Logon).HasColumnName("Logon").IsRequired().HasMaxLength(30);
            builder.Property(u => u.Senha).HasColumnName("Senha").IsRequired().HasMaxLength(100);
            builder.Property(u => u.TipoUsuarioId).HasColumnName("TipoUsuarioId").IsRequired();

            builder.HasIndex(u => u.TipoUsuarioId);
            builder.HasOne<TipoUsuario>().WithMany().HasForeignKey(u => u.TipoUsuarioId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_TipoUsuario_Usuario");
        }
    }
}
