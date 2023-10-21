using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class DepartamentoRepository : GenericRepository<Departamento>, IDepartamentoRepository
{
    private readonly APIContext _context;

    public DepartamentoRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}