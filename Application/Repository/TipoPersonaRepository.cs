using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class TipoPersonaRepository : GenericRepository<TipoPersona>, ITipoPersonaRepository
{
    private readonly APIContext _context;

    public TipoPersonaRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}