using Enee.Core.CQRS.Query;
using evaluacionUtcd.Domain.Modules.Factura.Features.CrearFactura;
using evaluacionUtcd.Domain.Modules.Factura.Features.EditarFactura;
using evaluacionUtcd.Domain.Modules.Factura.Features.EliminarFactura;

namespace evaluacionUtcd.Domain.Modules.Factura.Projections.FacturaTable;

public class FacturaProjector : TableProjector<Facturas>
{
    public FacturaProjector()
    {
        Create<FacturaCreada>((@event, tabla) =>
        {
            tabla.Id = @event.AggregateId;
            tabla.Numero = @event.Numero;
            tabla.FechaEmision = @event.FechaEmision;
            tabla.EstadoId = @event.EstadoId;
        });

        Project<FacturaEditada>((@event, tabla) =>
        {
            tabla.Numero = @event.Numero;
            tabla.FechaEmision = @event.FechaEmision;
            tabla.EstadoId = @event.EstadoId;
        });

        SoftDeleted<FacturaEliminada>();
    }
}

