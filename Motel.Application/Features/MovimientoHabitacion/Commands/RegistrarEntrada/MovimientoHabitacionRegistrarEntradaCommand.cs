using MediatR;

namespace Motel.Application.Features.MovimientoHabitacion.Commands.MovimientoHabitacionRegistrarEntrada
{
    public class RegistrarEntradaCommand : IRequest<int>
    {
        public int habitacion_id { get; set; }
        public int tarifa_id { get; set; }
        public int forma_pago_id { get; set; }
        public string palca_veiculo { get; set; } = string.Empty;
        public string descripcion_vehiculo { get; set; } = string.Empty;
        public string observaciones { get; set; } = string.Empty;
    }
}
