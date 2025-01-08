﻿using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using evaluacionUtcd.Domain.Modules.Factura.Features.ConsultarFacturas;
using MiFactura = evaluacionUtcd.Domain.Modules.Factura.Projections.FacturaTable.Facturas;

namespace evaluacionUtcd.Api.Modules.Factura.Features.ConsultarFacturas;

public static class Endpoint
{
    public static void ConsultarFacturas(this IEndpointRouteBuilder app)
    {
        app.MapGet("/", async (IQueryDispatcher dispatcher,[AsParameters]FacturasFilters filters) =>
            {
                var id = Guid.NewGuid();
               IPaginated<MiFactura>? result= await dispatcher.Execute(new ConsultarFacturaQuery(filters));
                return result;
            })
            .Produces<IPaginated<MiFactura>>()
            .WithSummary("Listado factura")
            .WithDescription("Permite listar facturas")
            .WithOpenApi();
        // .Access();
    }
}
