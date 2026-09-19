using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.SqlServer;

public sealed class ModeloRelatorioMapping : IEntityTypeConfiguration<ModeloRelatorio>
{
    public void Configure(EntityTypeBuilder<ModeloRelatorio> builder)
    {
        builder.ToTable("ModeloRelatorio");

        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).HasColumnName("Id").ValueGeneratedOnAdd();
        builder.Property(m => m.Descricao).HasColumnName("Descricao").HasMaxLength(50).IsUnicode(false).IsRequired();
        builder.Property(m => m.TipoModeloId).HasColumnName("TipoModeloId").IsRequired();
        builder.Property(m => m.Texto).HasColumnName("Texto").IsRequired(false);
        builder.Property(m => m.Ativo).HasColumnName("Ativo").IsRequired();

        builder.HasIndex(m => m.TipoModeloId);
        builder.HasOne<TipoModelo>().WithMany().HasForeignKey(m => m.TipoModeloId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("FK_TipoModelo_ModeloRelatorio");
    }
}
