using Motel.Domain.Entities.Common;

namespace Motel.Domain.Entities
{
    public class MovimientoHabitacionModel : BaseDomainModel
    {
        public int movimiento_habitacion_id { get; set; }
        public int habitacion_id { get; set; }
        public int tarifa_id { get; set; }
        public int forma_pago_id { get; set; }
        public string placa_vehiculo { get; set; } = string.Empty;
        public string descripcion_vehiculo { get; set; } = string.Empty;
        public DateTime entrada { get; set; }
        public DateTime salida { get; set; }
        public string observaciones { get; set; } = string.Empty;
    }
}
