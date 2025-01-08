using Enee.Core.CQRS.Command;
namespace evaluacionUtcd.Domain.Modules.Tarea.Features.CrearTarea
{
    public record CrearTareaCommand(
        Guid Id,
        string Nombre,
        string Descripcion,
        DateTime FechaInicio,
        DateTime? FechaFin,
        Guid TipoTareaId,
        Guid EstadoTareaId,
        Guid PrioridadTareaId
    ) : ICommand;
}
