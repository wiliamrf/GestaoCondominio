using GC.Business.Interfaces;
using GC.Business.Models;
using GC.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GC.Data.Repository
{
    public class CarroRepositoy : Repository<Carro>, ICarroRepository
    {
        public CarroRepositoy(GCDbContext context) : base(context)
        {
        }

        public async Task<Carro> ObterCarro(Guid id)
        {
            return await Db.Carros.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }

}
