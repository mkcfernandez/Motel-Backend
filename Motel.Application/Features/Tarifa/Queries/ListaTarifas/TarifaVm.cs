namespace Motel.Application.Features.Tarifa.Queries.ListaTarifas
{
    public class TarifaVm
    {
        public int motel_id { get; set; }
        public string motel_nombre_comercial { get; set; } = string.Empty;
        public int tipo_habitacion_id { get; set; }
        //public string tipo_habitacion_nombre { get; set; } = string.Empty;
        public decimal tarifa_costo { get; set; }
        public int tarifa_tiempo { get; set; }
    }
}
