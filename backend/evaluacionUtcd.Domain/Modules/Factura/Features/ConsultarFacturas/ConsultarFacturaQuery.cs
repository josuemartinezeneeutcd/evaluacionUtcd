using evaluacionUtcd.Domain.Modules.Factura.Projections.FacturaTable;
using evaluacionUtcd.Domain.Query;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.ConsultarFacturas;

public class ConsultarFacturaQuery:IPaginateQuery<FacturasFilters,Facturas>
{
    public ConsultarFacturaQuery(FacturasFilters filters)
    {
        Filters = filters;
    }

    public string Description { get; } = "Consultar Query";

    public FacturasFilters Filters { get; }
}
