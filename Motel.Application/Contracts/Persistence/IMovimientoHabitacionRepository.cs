using Motel.Application.Contracts.Persistence;
using Motel.Domain.Entities;

namespace Motel.Application.Contracts
{
    public interface IMovimientoHabitacionRepository : IAsyncRepository<MovimientoHabitacionModel>
    {
    }
}
