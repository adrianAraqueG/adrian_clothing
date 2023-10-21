using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class ProveedorConfiguration : IEntityTypeConfiguration<Proveedor>
{
    public void Configure(EntityTypeBuilder<Proveedor> builder)
    {
        builder.ToTable("Proveedores");

        builder.Property(p => p.NitProveedor)
        .IsRequired();

        builder.Property(p => p.Nombre)
        .IsRequired();

        builder.HasOne(p => p.Municipio)
        .WithMany(m => m.Proveedores)
        .HasForeignKey(p => p.IdMunicipio);

        builder.HasOne(p => p.TipoPersona)
        .WithMany(t => t.Proveedores)
        .HasForeignKey(p => p.IdTipoPersona);




        builder
        .HasMany(i => i.Insumos) //1
        .WithMany(p => p.Proveedores) //2
        .UsingEntity<InsumoProveedor>(
            j => j
            //1
            .HasOne(pt => pt.Insumo) // De intermedia
            .WithMany(t => t.InsumoProveedor) // De 1
            .HasForeignKey(ut => ut.IdProveedor), // De intermedia
            j => j
            //2
            .HasOne(et => et.Proveedor) // De intermedia
            .WithMany(et => et.InsumosProveedor) // De 2
            .HasForeignKey(el => el.IdInsumo), // De intermedia
            j =>
            {
                j.ToTable("InsumoProveedor"); // Nombre intermedia
                j.HasKey(t => new { t.IdInsumo, t.IdProveedor }); // De intermedia

            });
    }
}