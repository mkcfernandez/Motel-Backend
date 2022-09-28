using AutoMapper;
using MediatR;
using Motel.Application.Contracts.Persistence;

namespace Motel.Application.Features.Motel.Queries
{
    public class MotelesListaQueryHandler : IRequestHandler<MotelesListaQuery, List<MotelsVm>>
    {
        private readonly IMotelRepository _motelRepository;
        public readonly IMapper _mapper;

        public MotelesListaQueryHandler(IMotelRepository motelRepository, IMapper mapper)
        {
            _motelRepository = motelRepository;
            _mapper = mapper;
        }

        public async Task<List<MotelsVm>> Handle(MotelesListaQuery request, CancellationToken cancellationToken)
        {
            var entityList = await _motelRepository.GetAllAsync();
            return _mapper.Map<List<MotelsVm>>(entityList);
        }
    }
}
