using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class ClienteRepository : GenericRepository<Cliente>, IClienteRepository
{
    private readonly APIContext _context;

    public ClienteRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}