using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class OrdenRepository : GenericRepository<Orden>, IOrdenRepository
{
    private readonly APIContext _context;

    public OrdenRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}