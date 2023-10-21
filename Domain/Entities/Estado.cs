namespace Domain.Entities;

public class Estado : BaseEntity
{
    public string Descripción { get; set; }
    public int IdTipoEstado{get; set;}
    public TipoEstado TipoEstado {get; set;}

    public ICollection<Prenda> Prendas {get; set;}
    public ICollection<DetalleOrden> DetallesOrden {get; set;}
    public ICollection<Orden> Ordenes {get; set;}
}