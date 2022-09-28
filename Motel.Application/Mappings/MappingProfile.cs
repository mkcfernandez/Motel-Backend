using AutoMapper;
using Motel.Application.Features.Motel.Queries;
using Motel.Application.Features.MovimientoHabitacion.Commands.MovimientoHabitacionRegistrarEntrada;
using Motel.Application.Features.Tarifa.Queries.ListaTarifas;
using Motel.Domain.Entities;

namespace Motel.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RegistrarEntradaCommand, MovimientoHabitacionEntity>();
            CreateMap<MotelEntity, MotelsVm>();
            CreateMap<TarifaEntity, TarifaVm>();
        }
    }
}
