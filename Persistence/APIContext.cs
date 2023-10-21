using System.Reflection;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Persistence.Data.Configuration;

namespace Persistence;

public class APIContext : DbContext
{
    public APIContext(DbContextOptions<APIContext> options) : base(options){}

    public DbSet<Cargo> Cargos {get; set;}
    public DbSet<Cliente> Clientes {get; set;}
    public DbSet<Color> Colores {get; set;}
    public DbSet<Departamento> Departamentos {get; set;}
    public DbSet<DetalleOrden> DetallesOrden {get; set;}
    public DbSet<DetalleVenta> DetallesVenta {get; set;}
    public DbSet<Empleado> Empleados {get; set;}
    public DbSet<Empresa> Empresas {get; set;}
    public DbSet<Estado> Estados {get; set;}
    public DbSet<FormaPago> FormasPago {get; set;}
    public DbSet<Genero> Generos {get; set;}
    public DbSet<Insumo> Insumos {get; set;}
    public DbSet<Inventario> Inventarios {get; set;}
    public DbSet<Municipio> Municipios {get; set;}
    public DbSet<Orden> Ordenes {get; set;}
    public DbSet<Pais> Paises {get; set;}
    public DbSet<Prenda> Prendas {get; set;}
    public DbSet<Proveedor> Proveedores {get; set;}
    public DbSet<Talla> Tallas {get; set;}
    public DbSet<Venta> Ventas {get; set;}

    public DbSet<RefreshToken> RefreshTokens {get; set;}

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<UsuarioRol> UsuarioRoles { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

    }
}
