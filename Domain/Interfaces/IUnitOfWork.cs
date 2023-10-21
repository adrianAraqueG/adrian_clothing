using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    IRolRepository Roles { get; }
    IUsuarioRepository Usuarios { get; }
    IUsuarioRolRepository UsuarioRoles {get; }


    ICargoRepository Cargos {get; }
    IClienteRepository Clientes {get; }
    IColorRepository Colores {get; }
    IDepartamentoRepository Departamentos {get; }
    IDetalleOrdenRepository DetallesOrden {get; }
    IDetalleVentaRepository DetallesVenta {get; }
    IEmpleadoRepository Empleados {get; }
    IEmpresaRepository Empresas {get; }
    IEstadoRepository Estados {get; }
    IFormaPagoRepository FormasPago {get; }
    IGeneroRepository Generos {get; }
    IInsumoRepository Insumos {get; }
    IInventarioRepository Inventarios {get; }
    IMunicipioRepository Municipios {get; }
    IOrdenRepository Ordenes {get; }
    IPaisRepository Paises {get; }
    IPrendaRepository Prendas {get; }
    IProveedorRepository Proveedores {get; }
    ITallaRepository Tallas {get; }
    ITipoEstadoRepository TipoEstados {get; }
    ITipoPersonaRepository TipoPersonas {get; }
    IVentaRepository Ventas {get; }


    Task<int> SaveAsync();

}