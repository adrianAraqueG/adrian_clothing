using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class VentaConfiguration : IEntityTypeConfiguration<Venta>
{
    public void Configure(EntityTypeBuilder<Venta> builder)
    {
        builder.ToTable("Ventas");

        builder.HasOne(p => p.Empleado)
        .WithMany(m => m.Ventas)
        .HasForeignKey(p => p.IdEmpleado);

        builder.HasOne(p => p.Cliente)
        .WithMany(m => m.Ventas)
        .HasForeignKey(p => p.IdCliente);

        builder.HasOne(p => p.FormaPago)
        .WithMany(m => m.Ventas)
        .HasForeignKey(p => p.IdFormaPago);
    }
}