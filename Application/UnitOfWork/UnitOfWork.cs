using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly APIContext _context;

    private IRolRepository _roles;
    private IUsuarioRepository _usuarios;
    private IUsuarioRolRepository _usuarioRoles;
    private IEmpleadoRepository _empleados;
    private IColorRepository _Colores;
    private ICargoRepository _Cargos;
    private IClienteRepository _Clientes;
    private IDepartamentoRepository _Departamentos;
    private IDetalleOrdenRepository _DetallesOrden;
    private IDetalleVentaRepository _DetallesVenta;
    private IEmpresaRepository _Empresas;
    private IEstadoRepository _Estados;
    private IFormaPagoRepository _FormasPago;
    private IGeneroRepository _Generos;
    private IInsumoRepository _Insumos;
    private IInventarioRepository _Inventarios;
    private IMunicipioRepository _Municipios;
    private IOrdenRepository _Ordenes;
    private IPaisRepository _Paises;
    private IPrendaRepository _Prendas;
    private IProveedorRepository _Proveedores;
    private ITallaRepository _Tallas;
    private ITipoEstadoRepository _TipoEstados;
    private ITipoPersonaRepository _TipoPersonas;
    private IVentaRepository _Ventas;
    
    public UnitOfWork(APIContext context)
    {
        _context = context;
    }
    public IRolRepository Roles
    {
        get
        {
            if (_roles == null)
            {
                _roles = new RolRepository(_context);
            }
            return _roles;
        }
    }
    public IUsuarioRolRepository UsuarioRoles
    {
        get
        {
            if (_usuarioRoles == null)
            {
                _usuarioRoles = new UsuarioRolRepository(_context);
            }
            return _usuarioRoles;
        }
    }

    public IUsuarioRepository Usuarios
    {
        get
        {
            if (_usuarios == null)
            {
                _usuarios = new UsuarioRepository(_context);
            }
            return _usuarios;
        }
    }
    public IEmpleadoRepository Empleados
    {
        get
        {
            if (_empleados == null)
            {
                _empleados = new EmpleadoRepository(_context);
            }
            return _empleados;
        }
    }

    public IClienteRepository Clientes{
        get
        {
            if (_Clientes == null)
            {
                _Clientes = new ClienteRepository(_context);
            }
            return _Clientes;
        }
    }

    public IColorRepository Colores{
        get
        {
            if (_Colores == null)
            {
                _Colores = new ColorRepository(_context);
            }
            return _Colores;
        }
    }

    public IDepartamentoRepository Departamentos{
        get
        {
            if (_Departamentos == null)
            {
                _Departamentos = new DepartamentoRepository(_context);
            }
            return _Departamentos;
        }
    }

    public IDetalleOrdenRepository DetallesOrden{
        get
        {
            if (_DetallesOrden == null)
            {
                _DetallesOrden = new DetalleOrdenRepository(_context);
            }
            return _DetallesOrden;
        }
    }

    public IDetalleVentaRepository DetallesVenta{
        get
        {
            if (_DetallesVenta == null)
            {
                _DetallesVenta = new DetalleVentaRepository(_context);
            }
            return _DetallesVenta;
        }
    }

    public IEmpresaRepository Empresas{
        get
        {
            if (_Empresas == null)
            {
                _Empresas = new EmpresaRepository(_context);
            }
            return _Empresas;
        }
    }

    public IEstadoRepository Estados{
        get
        {
            if (_Estados == null)
            {
                _Estados = new EstadoRepository(_context);
            }
            return _Estados;
        }
    }

    public IFormaPagoRepository FormasPago{
        get
        {
            if (_FormasPago == null)
            {
                _FormasPago = new FormaPagoRepository(_context);
            }
            return _FormasPago;
        }
    }

    public IGeneroRepository Generos{
        get
        {
            if (_Generos == null)
            {
                _Generos = new GeneroRepository(_context);
            }
            return _Generos;
        }
    }

    public IInsumoRepository Insumos{
        get
        {
            if (_Insumos == null)
            {
                _Insumos = new InsumoRepository(_context);
            }
            return _Insumos;
        }
    }

    public IInventarioRepository Inventarios{
        get
        {
            if (_Inventarios == null)
            {
                _Inventarios = new InventarioRepository(_context);
            }
            return _Inventarios;
        }
    }

    public IMunicipioRepository Municipios{
        get
        {
            if (_Municipios == null)
            {
                _Municipios = new MunicipioRepository(_context);
            }
            return _Municipios;
        }
    }
    public IOrdenRepository Ordenes{
        get
        {
            if (_Ordenes == null)
            {
                _Ordenes = new OrdenRepository(_context);
            }
            return _Ordenes;
        }
    }

    public IPaisRepository Paises{
        get
        {
            if (_Paises == null)
            {
                _Paises = new PaisRepository(_context);
            }
            return _Paises;
        }
    }

    public IPrendaRepository Prendas{
        get
        {
            if (_Prendas == null)
            {
                _Prendas = new PrendaRepository(_context);
            }
            return _Prendas;
        }
    }

    public IProveedorRepository Proveedores{
        get
        {
            if (_Proveedores == null)
            {
                _Proveedores = new ProveedorRepository(_context);
            }
            return _Proveedores;
        }
    }

    public ITallaRepository Tallas{
        get
        {
            if (_Tallas == null)
            {
                _Tallas = new TallaRepository(_context);
            }
            return _Tallas;
        }
    }

    public ITipoEstadoRepository TipoEstados{
        get
        {
            if (_TipoEstados == null)
            {
                _TipoEstados = new TipoEstadoRepository(_context);
            }
            return _TipoEstados;
        }
    }

    public ITipoPersonaRepository TipoPersonas{
        get
        {
            if (_TipoPersonas == null)
            {
                _TipoPersonas = new TipoPersonaRepository(_context);
            }
            return _TipoPersonas;
        }
    }

    public IVentaRepository Ventas{
        get
        {
            if (_Ventas == null)
            {
                _Ventas = new VentaRepository(_context);
            }
            return _Ventas;
        }
    }

    public ICargoRepository Cargos{
        get
        {
            if (_Cargos == null)
            {
                _Cargos = new CargoRepository(_context);
            }
            return _Cargos;
        }
    }

    public async Task<int> SaveAsync()
    {
        return await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    } 
}
