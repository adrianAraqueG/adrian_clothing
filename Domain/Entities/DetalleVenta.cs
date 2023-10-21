using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public class DetalleVenta : BaseEntity
{
    public int Cantidad { get; set; }
    public double ValorUnitario { get; set; }
    public int IdVenta {get; set;}
    public Venta Venta {get; set;}
    public int IdInventario {get; set;}
    public Inventario Inventario {get; set;}
    public int IdTalla {get; set;}
    public Talla Talla {get; set;}
}