using Motel.Domain.Entities.Common;
using System.ComponentModel.DataAnnotations.Schema;

namespace Motel.Domain.Entities
{
    [Table("Motel", Schema = "Catalogo")]
    public class MotelEntity : BaseDomainModel
    {
        public string motel_nombre_comercial { get; set; } = string.Empty;
        public string motel_razon_social { get; set; } = string.Empty;
        public string motel_rfc { get; set; } = string.Empty;
        public string motel_regimen_fiscal { get; set; } = string.Empty;
        public string motel_direccion { get; set; } = string.Empty;
        public string motel_entre_calle { get; set; } = string.Empty;
        public string motel_ciudad { get; set; } = string.Empty;
        public string motel_estado { get; set; } = string.Empty;
        public int motel_codigo_postal { get; set; }
        public string motel_contacto { get; set; } = string.Empty;
        public string motel_correo { get; set; } = string.Empty;
        public int motel_telefono { get; set; }
        public int motel_estatus { get; set; }
    }
}
