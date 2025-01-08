using Enee.Core.Domain;

namespace evaluacionUtcd.Domain.Modules.Factura.Projections.FacturaTable;


public class Facturas : EntityAuditable<Guid>
{

    public string Numero { get; set; }
    public DateOnly FechaEmision { get; set; }
    public string EstadoId { get; set; }

}
