using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class MunicipioRepository : GenericRepository<Municipio>, IMunicipioRepository
{
    private readonly APIContext _context;

    public MunicipioRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}