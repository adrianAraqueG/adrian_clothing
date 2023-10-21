using System.Collections.Generic;

namespace Domain.Entities;

public class Proveedor : BaseEntity
{
    public string NitProveedor { get; set; }
    public string Nombre { get; set; }
    public int IdMunicipio {get; set;}
    public Municipio Municipio {get; set;}
    public int IdTipoPersona {get; set;}
    public TipoPersona TipoPersona {get; set;}

    public ICollection<Insumo> Insumos {get; set;} = new HashSet<Insumo>();
    public ICollection<InsumoProveedor> InsumosProveedor {get; set;} 
}