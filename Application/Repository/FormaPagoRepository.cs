using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class FormaPagoRepository : GenericRepository<FormaPago>, IFormaPagoRepository
{
    private readonly APIContext _context;

    public FormaPagoRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}