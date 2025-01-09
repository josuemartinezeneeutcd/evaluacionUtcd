using Enee.Core.CQRS.Command;
using evaluacionUtcd.Api.Modules.Tarea.Common;
using evaluacionUtcd.Api.Utilities.Response;
using evaluacionUtcd.Domain.Modules.Tarea.Features.CrearTarea;
using UtcdRefacturacion.Api.Endpoints.Tareas;

namespace evaluacionUtcd.Api.Modules.Tarea.Features.CrearTareas
{
    public static class Endpoint
    {
        public static void CrearTareaEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapPost(
                    "/",
                    async (TareaRequest request, IDispatcher dispatcher) =>
                    {
                        var id = Guid.NewGuid();
                        var result = await dispatcher.Dispatch(
                            new CrearTareaCommand(
                                id,
                                request.Nombre,
                                request.Descripcion,
                                request.FechaInicio,
                                request.FechaFin,
                                request.TipoTareaId,
                                request.EstadoTareaId,
                                request.PrioridadTareaId
                            )
                        );
                        return result.ToResponse(new TareaResponse { Id = id });
                    }
                )
            .Produces<TareaResponse>()
            .WithSummary("Creando una tarea")
            .WithDescription("Permite crear una nueva tarea")
            .WithOpenApi();
        }
    }
}
