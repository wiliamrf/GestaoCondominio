using GC.Business.Models;

namespace GC.Business.Interfaces
{
    public interface IMotoRepository : IRepository<Moto>
    {
        Task<Moto> ObterMoto(Guid id);
    }
}
