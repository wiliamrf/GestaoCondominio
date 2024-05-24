using GC.Business.Interfaces;
using GC.Business.Models;
using GC.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace GC.Data.Repository
{
    public class CorrespondeciaRepositoy : Repository<Correspondecia>, ICorrespondenciaRepository
    {
        public CorrespondeciaRepositoy(GCDbContext context) : base(context)
        {
        }

        public async Task<Correspondecia> ObterCorrespondecia(Guid id)
        {
            return await Db.Correspondeciaes.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }
    }

}
