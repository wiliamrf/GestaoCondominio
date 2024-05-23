using GC.Business.Models;

namespace GC.Business.Interfaces
{
    public interface ICarroRepository : IRepository<Carro>
    {
        Task<Carro> ObterCarro(Guid id);
    }
}
