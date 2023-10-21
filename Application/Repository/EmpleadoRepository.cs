using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository;
    public class EmpleadoRepository: GenericRepository<Empleado>, IEmpleadoRepository
{
    private readonly APIContext _context;

    public EmpleadoRepository(APIContext context) : base(context)
    {
       _context = context;
    }
}