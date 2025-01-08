using Carter;
using evaluacionUtcd.Api.Modules.Factura.Features.ConsultarFacturas;
using evaluacionUtcd.Api.Modules.Factura.Features.CrearFacturas;
using evaluacionUtcd.Api.Modules.Factura.Features.EditarFacturas;
using evaluacionUtcd.Api.Modules.Factura.Features.EliminarFactura;
using evaluacionUtcd.Api.Modules.Factura.Features.EliminarItemFactura;
using evaluacionUtcd.Api.Modules.Factura.Features.RecuperarFactura;

namespace evaluacionUtcd.Api.Modules.Factura;

public class Endpoints : CarterModule
{
    public Endpoints() : base("/api/v1/facturas")
    {
        this.WithTags("Facturas");

    }
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.CrearFactura();
        app.EditarFactura();
        app.RecuperarFactura();
        app.ConsultarFacturas();
        app.EliminarFactura();
        app.EliminarItemFactura();
    }
}
