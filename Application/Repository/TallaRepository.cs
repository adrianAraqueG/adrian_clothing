using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class TallaRepository : GenericRepository<Talla>, ITallaRepository
{
    private readonly APIContext _context;

    public TallaRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}