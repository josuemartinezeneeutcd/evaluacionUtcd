using Enee.Core.CQRS.Query;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.ConsultarFacturas;

public class FacturasFilters:IPaginatedParams
{
    public string? Numero { get; set; }
    public int? PageSize { get; set; }
    public int? Page { get; set; }
}
