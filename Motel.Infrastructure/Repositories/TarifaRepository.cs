using Microsoft.EntityFrameworkCore;
using Motel.Application.Contracts.Persistence;
using Motel.Domain.Entities;
using Motel.Infrastructure.Persistence;

namespace Motel.Infrastructure.Repositories
{
    public class TarifaRepository : RepositoryBase<TarifaEntity>, ITarifaRepository
    {
        public TarifaRepository(MotelDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<TarifaEntity>> GetTarifaByMotelId(int motel_id)
        {
            return await _context.Tarifa!.Where(m => m.motel_id == motel_id).ToListAsync();
        }
    }
}
