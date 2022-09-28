using Motel.Application.Contracts;
using Motel.Domain.Entities;
using Motel.Infrastructure.Persistence;

namespace Motel.Infrastructure.Repositories
{
    public class MovimietnoHabitacionRepository : RepositoryBase<MovimientoHabitacionEntity>, IMovimientoHabitacionRepository
    {
        public MovimietnoHabitacionRepository(MotelDbContext context) : base(context)
        {
        }
    }
}
