namespace API.Dtos;

public class ClienteDto
{
    public int Id { get; set; }
    public string Descripción { get; set; }
    public int IdTipoEstado{get; set;}
    // public TipoEstado TipoEstado {get; set;}

    // public ICollection<Prenda> Prendas {get; set;}
    // public ICollection<DetalleOrden> DetallesOrden {get; set;}
    // public ICollection<Orden> Ordenes {get; set;}
}