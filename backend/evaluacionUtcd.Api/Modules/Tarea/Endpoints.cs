using Carter;
using evaluacionUtcd.Api.Modules.Tarea.Features.ConsultarTareas;
using evaluacionUtcd.Api.Modules.Tarea.Features.CrearTareas;
using evaluacionUtcd.Api.Modules.Tarea.Features.EditarTareas;

namespace evaluacionUtcd.Api.Modules.Tarea
{
    public class Endpoints : CarterModule
    {
        public Endpoints()
        : base("/api/v1/tareas")
        {
            this.WithTags("Tareas");
        }
        public override void AddRoutes(IEndpointRouteBuilder app)
        {
            app.CrearTareaEndpoint();
            app.EditarTareaEndpoint();
            app.RecuperarTareasEndpoint();
        }
    }
}
