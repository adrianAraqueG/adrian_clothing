using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class TallaConfiguration : IEntityTypeConfiguration<Talla>
{
    public void Configure(EntityTypeBuilder<Talla> builder)
    {
        builder.ToTable("Tallas");


        builder
        .HasMany(i => i.Inventarios) //1
        .WithMany(p => p.Tallas) //2
        .UsingEntity<InventarioTalla>(
            j => j
            //1
            .HasOne(pt => pt.Inventario) // De intermedia
            .WithMany(t => t.InventarioTallas) // De 1
            .HasForeignKey(ut => ut.IdInventario), // De intermedia
            j => j
            //2
            .HasOne(et => et.Talla) // De intermedia
            .WithMany(et => et.InventarioTallas) // De 2
            .HasForeignKey(el => el.IdInventario), // De intermedia
            j =>
            {
                j.ToTable("InventarioTalla"); // Nombre intermedia
                j.HasKey(t => new { t.IdTalla, t.IdInventario }); // De intermedia

            });
    }
}