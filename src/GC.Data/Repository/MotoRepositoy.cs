using GC.Business.Interfaces;
using GC.Business.Models;
using GC.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GC.Data.Repository
{
    public class MotoRepositoy : Repository<Moto>, IMotoRepository
    {
        public MotoRepositoy(GCDbContext context) : base(context)
        {
        }

        public async Task<Moto> ObterMoto(Guid id)
        {
            return await Db.Motos.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }

}
