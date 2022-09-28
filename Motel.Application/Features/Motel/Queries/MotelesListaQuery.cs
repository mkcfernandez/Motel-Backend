using MediatR;

namespace Motel.Application.Features.Motel.Queries
{
    public class MotelesListaQuery : IRequest<List<MotelsVm>>
    {
    }
}
