using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class InventarioRepository : GenericRepository<Inventario>, IInventarioRepository
{
    private readonly APIContext _context;

    public InventarioRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}