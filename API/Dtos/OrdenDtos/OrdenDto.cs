namespace API.Dtos;

public class OrdenDto
{
    public int Id { get; set; }
    public DateTime Fecha { get; set; }
    public int IdEmpleado {get; set;}
    public EmpleadoSimpleDto Empleado {get; set;}
    public int IdCliente {get; set;}
    public ClienteSimpleDto Cliente {get; set;}
    public int IdEstado {get; set;}
    public EstadoSimpleDto Estado{get; set;}
}