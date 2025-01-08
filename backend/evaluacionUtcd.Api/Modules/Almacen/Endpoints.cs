using Carter;
using evaluacionUtcd.Api.Modules.Almacen.Features.CrearAlmacen;
using evaluacionUtcd.Api.Modules.Almacen.Features.RecuperarAlmacenes;

namespace evaluacionUtcd.Api.Modules.Almacen;

public class Endpoints:CarterModule
{
    public Endpoints():base("/api/v1/almacen")
    {
        this.WithTags("Almacen");

    }
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
          app.CrearAlmancen();
          app.RecuperarAlmacenes();
    }
}
