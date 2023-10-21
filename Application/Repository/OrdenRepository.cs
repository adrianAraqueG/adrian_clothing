using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;

public class OrdenRepository : GenericRepository<Orden>, IOrdenRepository
{
    private readonly APIContext _context;

    public OrdenRepository(APIContext context) : base(context)
    {
       _context = context;
    }

    public async Task<IEnumerable<Orden>> ObtenerOrdenXEstado(string estado)
    {
        var result = await _context.Ordenes
                            .Include(p => p.Estado)
                            .Include(p => p.Cliente)
                            .Include(p => p.Empleado)
                            .Where(o => o.Estado.Descripción == estado)
                            .ToListAsync();
        return result;
    }
}