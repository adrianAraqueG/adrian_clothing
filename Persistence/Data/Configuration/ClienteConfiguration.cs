using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration;

public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
{
    public void Configure(EntityTypeBuilder<Cliente> builder)
    {
        builder.ToTable("Clientes");

        builder.HasOne(p => p.TipoPersona)
        .WithMany(m => m.Clientes)
        .HasForeignKey(p => p.IdTipoPersona);

        builder.HasOne(p => p.Municipio)
        .WithMany(m => m.Clientes)
        .HasForeignKey(p => p.IdMunicipio);
    }
}