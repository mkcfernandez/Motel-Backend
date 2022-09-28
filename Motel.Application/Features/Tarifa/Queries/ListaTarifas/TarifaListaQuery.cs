using MediatR;

namespace Motel.Application.Features.Tarifa.Queries.ListaTarifas
{
    public class TarifaListaQuery : IRequest<List<TarifaVm>>
    {
        public int _motel_id { get; set; } = 0;

        public TarifaListaQuery(int motel_id)
        {
            _motel_id = motel_id;
        }
    }
}
