using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.Repository;

public class ColorRepository : GenericRepository<Color>, IColorRepository
{
    private readonly APIContext _context;

    public ColorRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}