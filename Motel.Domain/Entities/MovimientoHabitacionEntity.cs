using Motel.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Motel.Domain.Entities
{
    [Table("MovimientoHabitacion", Schema = "Operativo")]
    public class MovimientoHabitacionEntity : BaseDomainModel
    {
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
