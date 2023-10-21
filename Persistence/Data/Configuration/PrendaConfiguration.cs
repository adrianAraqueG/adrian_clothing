using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class PrendaConfiguration : IEntityTypeConfiguration<Prenda>
{
    public void Configure(EntityTypeBuilder<Prenda> builder)
    {
        builder.ToTable("Prendas");

        builder.HasOne(p => p.Estado)
        .WithMany(m => m.Prendas)
        .HasForeignKey(p => p.IdEstado);

        builder.HasOne(p => p.TipoProteccion)
        .WithMany(t => t.Prendas)
        .HasForeignKey(p => p.IdTipoProteccion);

        builder.HasOne(p => p.Genero)
        .WithMany(t => t.Prendas)
        .HasForeignKey(p => p.IdGenero);




        builder
        .HasMany(i => i.Insumos) //1
        .WithMany(p => p.Prendas) //2
        .UsingEntity<InsumoPrenda>(
            j => j
            //1
            .HasOne(pt => pt.Insumo) // De intermedia
            .WithMany(t => t.InsumoPrendas) // De 1
            .HasForeignKey(ut => ut.IdPrenda), // De intermedia
            j => j
            //2
            .HasOne(et => et.Prenda) // De intermedia
            .WithMany(et => et.InsumoPrenda) // De 2
            .HasForeignKey(el => el.IdInsumo), // De intermedia
            j =>
            {
                j.ToTable("InsumoPrenda"); // Nombre intermedia
                j.HasKey(t => new { t.IdInsumo, t.IdPrenda }); // De intermedia

            });
    }
}