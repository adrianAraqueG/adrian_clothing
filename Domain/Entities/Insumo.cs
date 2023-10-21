using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class Insumo : BaseEntity
{
    public string Nombre { get; set; }
    public double ValorUnitario {get; set;}
    public double StockMin {get; set;}
    public double StockMax {get; set;}

    public ICollection<Prenda> Prendas {get; set;} = new HashSet<Prenda>();
    public ICollection<InsumoPrenda> InsumoPrendas { get; set; }
    public ICollection<Proveedor> Proveedores {get; set;} = new HashSet<Proveedor>();
    public ICollection<InsumoProveedor> InsumoProveedor { get; set; }
}