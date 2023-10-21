using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class GeneroRepository : GenericRepository<Genero>, IGeneroRepository
{
    private readonly APIContext _context;

    public GeneroRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}