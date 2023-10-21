using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
{
    public void Configure(EntityTypeBuilder<Empleado> builder)
    {
        builder.ToTable("Empleados");

        builder.HasOne(p => p.Cargo)
        .WithMany(m => m.Empleados)
        .HasForeignKey(p => p.IdCargo);

        builder.HasOne(p => p.Municipio)
        .WithMany(m => m.Empleados)
        .HasForeignKey(p => p.IdMunicipio);
    }
}