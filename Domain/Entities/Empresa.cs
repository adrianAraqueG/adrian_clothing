namespace Domain.Entities;

public class Empresa : BaseEntity
{
    public string NitEmpresa { get; set; }
    public string RazonSocial { get; set; }
    public string RepresentanteLegal { get; set; }
    public string FechaCreacion { get; set; }
    public int IdMunicipio { get; set; }
    public Municipio Municipio {get; set;}
}