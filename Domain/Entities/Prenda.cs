namespace Domain.Entities;

public class Prenda : BaseEntity
{
    public string Nombre { get; set;}
    public int ValorUnitarioCop {get; set;}
    public int ValorUnitarioUsd {get; set;}
    public int IdEstado {get; set;}
    public Estado Estado {get; set;}
    public int IdTipoProteccion {get; set;}
    public TipoProteccion TipoProteccion {get; set;}
    public int IdGenero {get; set;}
    public Genero Genero {get; set;}

    public ICollection<Inventario> Inventarios {get; set;}
    public ICollection<DetalleOrden> DetallesOrden {get; set;}
    public ICollection<Insumo> Insumos = new HashSet<Insumo>();
    public ICollection<InsumoPrenda> InsumoPrenda {get; set;}
}