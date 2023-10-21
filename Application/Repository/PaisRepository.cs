using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class PaisRepository : GenericRepository<Pais>, IPaisRepository
{
    private readonly APIContext _context;

    public PaisRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}