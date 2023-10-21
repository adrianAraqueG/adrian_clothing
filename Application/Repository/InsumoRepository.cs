using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class InsumoRepository : GenericRepository<Insumo>, IInsumoRepository
{
    private readonly APIContext _context;

    public InsumoRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}