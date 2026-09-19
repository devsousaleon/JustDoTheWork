using JustDoTheWork.Entity.DatabaseClasses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JustDoTheWork.Infrastructure.Mappings.Postgres;

public sealed class ModeloRelatorioMapping : IEntityTypeConfiguration<ModeloRelatorio>
{
    public void Configure(EntityTypeBuilder<ModeloRelatorio> builder)
    {
        builder.ToTable("modelorelatorio");

        builder.HasKey(m => m.Id);
        builder.Property(m => m.Id).HasColumnName("id").ValueGeneratedOnAdd();
        builder.Property(m => m.Descricao).HasColumnName("descricao").HasMaxLength(50).IsRequired();
        builder.Property(m => m.TipoModeloId).HasColumnName("tipomodeloid").IsRequired();
        builder.Property(m => m.Texto).HasColumnName("texto").IsRequired(false);
        builder.Property(m => m.Ativo).HasColumnName("ativo").IsRequired();
        
        builder.HasIndex(m => m.TipoModeloId).HasDatabaseName("ix_modelorelatorio_tipomodeloid");
        builder.HasOne<TipoModelo>().WithMany().HasForeignKey(m => m.TipoModeloId).OnDelete(DeleteBehavior.NoAction).HasConstraintName("fk_tipomodelo_modelorelatorio");
    }
}
