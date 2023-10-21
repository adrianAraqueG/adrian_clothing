using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class PrendaRepository : GenericRepository<Prenda>, IPrendaRepository
{
    private readonly APIContext _context;

    public PrendaRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}