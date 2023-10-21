using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class DetalleVentaConfiguration : IEntityTypeConfiguration<DetalleVenta>
{
    public void Configure(EntityTypeBuilder<DetalleVenta> builder)
    {
        builder.ToTable("DetallesVenta");

        builder.HasOne(p => p.Venta)
        .WithMany(m => m.DetallesVenta)
        .HasForeignKey(p => p.IdVenta);

        builder.HasOne(p => p.Inventario)
        .WithMany(m => m.DetallesVenta)
        .HasForeignKey(p => p.IdInventario);

        builder.HasOne(p => p.Talla)
        .WithMany(m => m.DetallesVenta)
        .HasForeignKey(p => p.IdTalla);
    }
}