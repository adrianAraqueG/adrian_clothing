using Microsoft.AspNetCore.Mvc;

namespace API.Dtos;

public class OrdenRegDto
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public int IdEmpleado {get; set;}
    public int IdCliente {get; set;}
    public int IdEstado {get; set;}
}