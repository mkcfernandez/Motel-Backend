using Motel.Domain.Entities;

namespace Motel.Application.Contracts.Persistence
{
    public interface IMotelRepository : IAsyncRepository<MotelEntity>
    {
    }
}
