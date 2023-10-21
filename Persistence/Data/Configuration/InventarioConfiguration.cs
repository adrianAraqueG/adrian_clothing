using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class InventarioConfiguration : IEntityTypeConfiguration<Inventario>
{
    public void Configure(EntityTypeBuilder<Inventario> builder)
    {
        builder.ToTable("Inventarios");

        builder.HasOne(p => p.Prenda)
        .WithMany(m => m.Inventarios)
        .HasForeignKey(p => p.IdPrenda);




        builder
        .HasMany(i => i.Tallas) //1
        .WithMany(p => p.Inventarios) //2
        .UsingEntity<InventarioTalla>(
            j => j
            //1
            .HasOne(pt => pt.Talla) // De intermedia
            .WithMany(t => t.InventarioTallas) // De 1
            .HasForeignKey(ut => ut.IdTalla), // De intermedia
            j => j
            //2
            .HasOne(et => et.Inventario) // De intermedia
            .WithMany(et => et.InventarioTallas) // De 2
            .HasForeignKey(el => el.IdInventario), // De intermedia
            j =>
            {
                j.ToTable("InventarioTalla"); // Nombre intermedia
                j.HasKey(t => new { t.IdTalla, t.IdInventario }); // De intermedia

            });
    }
}