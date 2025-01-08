using Enee.Core.CQRS.Query;
using evaluacionUtcd.Domain.Modules.Factura.Features.ConsultarFacturas;
using evaluacionUtcd.Domain.Modules.Factura.Projections.FacturaTable;
using evaluacionUtcd.Domain.Query;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.RecuperarFacturas;

public class RecuperarFacturaQuery:IQuery<Facturas?>
{
    public RecuperaFacturaFilter Filters { get; }

    public RecuperarFacturaQuery(RecuperaFacturaFilter filters)
    {
        Filters = filters;
    }

    public string Description { get; } = "Recuperar factura";


}
