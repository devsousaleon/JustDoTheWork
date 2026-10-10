using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.Postgres;

public sealed class UsuarioMapping : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("usuario");

        builder.HasKey(u => u.Id);
        builder.Property(u => u.Id).HasColumnName("id").UseIdentityByDefaultColumn();
        builder.Property(u => u.Nome).HasColumnName("nome").HasMaxLength(30).IsRequired();
        builder.Property(u => u.Logon).HasColumnName("logon").HasMaxLength(30).IsRequired();
        builder.Property(u => u.Senha).HasColumnName("senha").HasMaxLength(100).IsRequired();
        builder.Property(u => u.TipoUsuarioId).HasColumnName("tipousuarioid").IsRequired();

        builder.HasIndex(u => u.TipoUsuarioId).HasDatabaseName("ix_usuario_tipousuarioid");
        builder.HasOne<TipoUsuario>()
            .WithMany()
            .HasForeignKey(u => u.TipoUsuarioId)
            .OnDelete(DeleteBehavior.NoAction)
            .HasConstraintName("fk_tipousuario_usuario");
    }
}
