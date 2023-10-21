namespace API.Dtos;

public class EmpleadoSimpleDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaIngreso { get; set; }
    public int IdCargo {get; set;}
    public int IdMunicipio {get; set;}
}