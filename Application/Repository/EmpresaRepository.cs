using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class EmpresaRepository : GenericRepository<Empresa>, IEmpresaRepository
{
    private readonly APIContext _context;

    public EmpresaRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}