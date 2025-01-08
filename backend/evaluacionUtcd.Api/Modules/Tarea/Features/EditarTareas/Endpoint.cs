using Enee.Core.CQRS.Command;
using evaluacionUtcd.Api.Modules.Tarea.Common;
using evaluacionUtcd.Domain.Modules.Tarea.Features.EditarTarea;
using Microsoft.AspNetCore.Mvc;
using evaluacionUtcd.Api.Utilities.Response;
using UtcdRefacturacion.Api.Endpoints.Tareas;


namespace evaluacionUtcd.Api.Modules.Tarea.Features.EditarTareas
{
    public static class Endpoint
    {
        public static void EditarTareaEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapPut(
                    "/{id}",
                    async (
                        [FromRoute] Guid id,
                        [FromBody] TareaRequest request,
                        IDispatcher dispatcher
                    ) =>
                    {
                        var result = await dispatcher.Dispatch(
                            new EditarTareaCommand(
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
                .WithSummary("Editando tareas")
                .WithDescription("Permite editar una tarea existente")
                .WithOpenApi();
        }
    }
}
