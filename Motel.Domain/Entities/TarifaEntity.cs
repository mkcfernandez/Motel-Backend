using Motel.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Motel.Domain.Entities
{
    [Table("Tarifa", Schema = "Catalogo")]
    public class TarifaEntity : BaseDomainModel
    {
        public int motel_id { get; set; }
        public int tipo_habitacion_id { get; set; }
        public decimal tarifa_costo { get; set; }
        public int tarifa_tiempo { get; set; }
    }
}
