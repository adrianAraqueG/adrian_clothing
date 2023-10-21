using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class DetalleOrdenRepository : GenericRepository<DetalleOrden>, IDetalleOrdenRepository
{
    private readonly APIContext _context;

    public DetalleOrdenRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}