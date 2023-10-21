using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IOrdenRepository : IGenericRepository<Orden>
    {
        Task<IEnumerable<Orden>> ObtenerOrdenXEstado(string estado);
    }
}