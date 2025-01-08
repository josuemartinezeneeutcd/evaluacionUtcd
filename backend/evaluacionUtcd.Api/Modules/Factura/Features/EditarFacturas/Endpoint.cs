using evaluacionUtcd.Api.Modules.Factura.Features.CrearFacturas;
using evaluacionUtcd.Api.Utilities.Response;
using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using Enee.Core.CQRS.Validation;
using evaluacionUtcd.Domain.Modules.Factura.Features.EditarFactura;
using Microsoft.AspNetCore.Mvc;

namespace evaluacionUtcd.Api.Modules.Factura.Features.EditarFacturas;

public static class Endpoint
{
    public static void EditarFactura(this IEndpointRouteBuilder app)
    {
        app.MapPut("/{id}",
                async ([FromRoute] Guid id, [FromBody] EditRequest request, IDispatcher dispatcher) =>
                {
                    Either<OK, List<MessageValidation>>? result = await dispatcher.Dispatch(new EditarFacturaCommand(
                        id,
                        request.Numero,
                        request.FechaEmision,
                        request.EstadoId
                    ));
                    return result.ToResponse(new FacturaResponse() { Id = id });
                })
            .Produces<FacturaResponse>()
            .WithSummary("Editar factura")
            .WithDescription("Permite editar factura")
            .WithOpenApi();
        // .Access();
    }
}
