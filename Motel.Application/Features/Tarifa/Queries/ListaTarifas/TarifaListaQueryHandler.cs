using AutoMapper;
using MediatR;
using Motel.Application.Contracts.Persistence;

namespace Motel.Application.Features.Tarifa.Queries.ListaTarifas
{
    public class TarifaListaQueryHandler : IRequestHandler<TarifaListaQuery, List<TarifaVm>>
    {
        private readonly ITarifaRepository _tarifaRepository;
        private readonly IMotelRepository _motelRepository;
        private readonly IMapper _mapper;

        public TarifaListaQueryHandler(ITarifaRepository tarifaRepository, IMapper mapper, IMotelRepository motelRepository)
        {
            _tarifaRepository = tarifaRepository;
            _mapper = mapper;
            _motelRepository = motelRepository;
        }

        public async Task<List<TarifaVm>> Handle(TarifaListaQuery request, CancellationToken cancellationToken)
        {
            var motelNombre = await _motelRepository.GetAsync(m => m.Id == request._motel_id);
            var entityList = await _tarifaRepository.GetTarifaByMotelId(request._motel_id);

            var result = _mapper.Map<List<TarifaVm>>(entityList);

            foreach (var item in result)
            {
                item.motel_nombre_comercial = motelNombre[0].motel_nombre_comercial;
            }

            return result;
        }
    }
}
