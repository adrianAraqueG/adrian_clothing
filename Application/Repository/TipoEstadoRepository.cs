using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class TipoEstadoRepository : GenericRepository<TipoEstado>, ITipoEstadoRepository
{
    private readonly APIContext _context;

    public TipoEstadoRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}