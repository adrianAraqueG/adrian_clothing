using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class VentaRepository : GenericRepository<Venta>, IVentaRepository
{
    private readonly APIContext _context;

    public VentaRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}