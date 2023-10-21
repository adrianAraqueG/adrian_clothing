using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class CargoRepository : GenericRepository<Cargo>, ICargoRepository
{
    private readonly APIContext _context;

    public CargoRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}