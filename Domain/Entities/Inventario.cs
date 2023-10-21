namespace Domain.Entities;

public class Inventario : BaseEntity
{
    public string CodInventario { get; set; }
    public double ValorVentaCop { get; set; }
    public double ValorVentaUsd { get; set; }
    public int IdPrenda {get; set;}
    public Prenda Prenda {get; set;}

    public ICollection<DetalleVenta> DetallesVenta {get; set;}
    public ICollection<Talla> Tallas {get; set;} = new HashSet<Talla>();
    public ICollection<InventarioTalla> InventarioTallas {get; set;}
}