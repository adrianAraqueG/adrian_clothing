namespace Domain.Entities;

public class Color : BaseEntity
{
    public string Descripcion { get; set; }
    public ICollection<DetalleOrden> DetallesOrden {get; set;}
}