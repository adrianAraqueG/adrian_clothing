namespace Domain.Entities;

public class Talla : BaseEntity
{
    public string Descripcion { get; set; }
    public ICollection<DetalleVenta> DetallesVenta {get; set;}
    public ICollection<Inventario> Inventarios {get; set;} = new HashSet<Inventario>();
    public ICollection<InventarioTalla> InventarioTallas {get; set;}
}