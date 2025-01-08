
using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using evaluacionUtcd.Domain.Modules.Tarea.Features.ConsultarTareas;
using evaluacionUtcd.Domain.Modules.Tarea.Projections;
namespace evaluacionUtcd.Api.Modules.Tarea.Features.ConsultarTareas
{
    public static class Endpoint
    {
        public static void RecuperarTareasEndpoint(this IEndpointRouteBuilder app)
        {
            app.MapGet(
                    "/",
                    async (
                        [AsParameters] ConsultarTareasPaginadoQuery query,
                        IQueryDispatcher dispatcher
                    ) =>
                    {
                        var result = await dispatcher.Execute(query);
                        return result;
                    }
                )
                .Produces<IPaginated<TareaTabla>>()
                .WithSummary("Obtiene listado de Tareas")
                .WithDescription("Listar Tareas con filtros y paginación")
                .WithOpenApi();
        }
    }
}
