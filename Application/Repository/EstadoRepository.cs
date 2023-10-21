using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class EstadoRepository : GenericRepository<Estado>, IEstadoRepository
{
    private readonly APIContext _context;

    public EstadoRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}