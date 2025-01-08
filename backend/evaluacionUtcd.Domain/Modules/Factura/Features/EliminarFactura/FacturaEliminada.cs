using Enee.Core.Common;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.EliminarFactura;

public class FacturaEliminada:DomainEvent<Guid>
{
    public FacturaEliminada(Guid aggregateId) : base(aggregateId)
    {
    }
}
