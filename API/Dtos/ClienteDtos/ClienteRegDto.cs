namespace API.Dtos;

public class ClienteRegDto
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public DateTime FechaRegistro {get; set;}
    public int IdTipoPersona {get; set;}
    public int IdMunicipio {get; set;}
}