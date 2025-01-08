﻿using evaluacionUtcd.Api.Modules.Factura.Features.CrearFacturas;
using evaluacionUtcd.Api.Utilities.Response;
using Enee.Core.Common.Util;
using Enee.Core.CQRS.Command;
using Enee.Core.CQRS.Validation;
using evaluacionUtcd.Domain.Modules.Factura.Features.EliminarFactura;
using Microsoft.AspNetCore.Mvc;

namespace evaluacionUtcd.Api.Modules.Factura.Features.EliminarFactura;

public static class Endpoint
{
    public static void EliminarFactura(this IEndpointRouteBuilder app)
    {
        app.MapDelete("/{id}", async ([FromRoute] Guid id,IDispatcher dispatcher) =>
            {
                Either<OK, List<MessageValidation>>? result = await dispatcher.Dispatch(new EliminarFacturaCommand(id));

                return result.ToResponse(new FacturaResponse() { Id = id });
            })
            .Produces<FacturaResponse>()
            .WithSummary("Eliminar factura")
            .WithDescription("Permite eliminar factura")
            .WithOpenApi();
        // .Access();
    }
}
