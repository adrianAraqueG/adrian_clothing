namespace Domain.Entities;

public class InsumoPrenda : BaseEntity
{
    public int Cantidad {get; set;}
    public int IdInsumo { get; set; }
    public Insumo Insumo {get; set;}
    public int IdPrenda { get; set; }
    public Prenda Prenda {get; set;}
}