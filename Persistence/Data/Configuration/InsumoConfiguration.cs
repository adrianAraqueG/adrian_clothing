using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class InsumoConfiguration : IEntityTypeConfiguration<Insumo>
{
    public void Configure(EntityTypeBuilder<Insumo> builder)
    {
        builder.ToTable("Insumos");

        builder.Property(p => p.Nombre)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.ValorUnitario)
        .HasMaxLength(50)
        .IsRequired();

        builder.Property(p => p.StockMin)
        .HasMaxLength(100)
        .IsRequired();

        builder.Property(p => p.StockMax)
        .IsRequired()
        .HasMaxLength(100);


        builder
        .HasMany(i => i.Proveedores)
        .WithMany(p => p.Insumos)
        .UsingEntity<InsumoProveedor>(
            j => j
            .HasOne(pt => pt.Proveedor)
            .WithMany(t => t.InsumosProveedor)
            .HasForeignKey(ut => ut.IdProveedor),
            j => j
            .HasOne(et => et.Insumo)
            .WithMany(et => et.InsumoProveedor)
            .HasForeignKey(el => el.IdInsumo),
            j =>
            {
                j.ToTable("InsumoProveedor");
                j.HasKey(t => new { t.IdInsumo, t.IdProveedor });

            });
            
        builder
        .HasMany(i => i.Prendas)
        .WithMany(p => p.Insumos)
        .UsingEntity<InsumoPrenda>(
            j => j
            .HasOne(pt => pt.Prenda)
            .WithMany(t => t.InsumoPrenda)
            .HasForeignKey(ut => ut.IdPrenda),
            j => j
            .HasOne(et => et.Insumo)
            .WithMany(et => et.InsumoPrendas)
            .HasForeignKey(el => el.IdInsumo),
            j =>
            {
                j.ToTable("InsumoPrenda");
                j.HasKey(t => new { t.IdInsumo, t.IdPrenda });

            });

    }
}