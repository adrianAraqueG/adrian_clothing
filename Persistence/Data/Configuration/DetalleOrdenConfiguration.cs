using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class DetalleOrdenConfiguration : IEntityTypeConfiguration<DetalleOrden>
{
    public void Configure(EntityTypeBuilder<DetalleOrden> builder)
    {
        builder.ToTable("DetallesOrden");

        builder.HasOne(p => p.Orden)
        .WithMany(m => m.DetallesOrden)
        .HasForeignKey(p => p.IdOrden);

        builder.HasOne(p => p.Prenda)
        .WithMany(m => m.DetallesOrden)
        .HasForeignKey(p => p.IdPrenda);

        builder.HasOne(p => p.Color)
        .WithMany(m => m.DetallesOrden)
        .HasForeignKey(p => p.IdColor);

        builder.HasOne(p => p.Estado)
        .WithMany(m => m.DetallesOrden)
        .HasForeignKey(p => p.IdEstado);
    }
}