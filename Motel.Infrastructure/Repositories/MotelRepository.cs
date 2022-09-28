using Motel.Application.Contracts.Persistence;
using Motel.Domain.Entities;
using Motel.Infrastructure.Persistence;

namespace Motel.Infrastructure.Repositories
{
    public class MotelRepository : RepositoryBase<MotelEntity>, IMotelRepository
    {
        public MotelRepository(MotelDbContext context) : base(context)
        {
        }
    }
}
