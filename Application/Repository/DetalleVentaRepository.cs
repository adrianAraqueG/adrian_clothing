using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class DetalleVentaRepository : GenericRepository<DetalleVenta>, IDetalleVentaRepository
{
    private readonly APIContext _context;

    public DetalleVentaRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}