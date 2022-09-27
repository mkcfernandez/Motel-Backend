using AutoMapper;
using Motel.Application.Features.MovimientoHabitacion.Commands.MovimientoHabitacionRegistrarEntrada;
using Motel.Domain.Entities;

namespace Motel.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<MovimientoHabitacionRegistrarEntradaCommand, MovimientoHabitacionModel>();
        }
    }
}
