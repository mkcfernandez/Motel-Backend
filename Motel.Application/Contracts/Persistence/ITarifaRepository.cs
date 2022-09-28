using Motel.Domain.Entities;

namespace Motel.Application.Contracts.Persistence
{
    public interface ITarifaRepository : IAsyncRepository<TarifaEntity>
    {
        Task<IEnumerable<TarifaEntity>> GetTarifaByMotelId(int motel_id);
    }
}
