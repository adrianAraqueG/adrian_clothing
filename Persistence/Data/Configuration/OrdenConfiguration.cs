using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class OrdenConfiguration : IEntityTypeConfiguration<Orden>
{
    public void Configure(EntityTypeBuilder<Orden> builder)
    {
        builder.ToTable("Ordenes");

        builder.HasOne(p => p.Empleado)
        .WithMany(m => m.Ordenes)
        .HasForeignKey(p => p.IdEmpleado);

        builder.HasOne(p => p.Cliente)
        .WithMany(m => m.Ordenes)
        .HasForeignKey(p => p.IdCliente);

        builder.HasOne(p => p.Estado)
        .WithMany(m => m.Ordenes)
        .HasForeignKey(p => p.IdEstado);
    }
}