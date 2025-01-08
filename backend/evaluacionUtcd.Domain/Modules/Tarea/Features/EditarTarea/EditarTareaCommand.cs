using Enee.Core.CQRS.Command;

namespace evaluacionUtcd.Domain.Modules.Tarea.Features.EditarTarea
{
    public record EditarTareaCommand(
        Guid Id,
        string Nombre,
        string Descripcion,
        DateTime FechaInicio,
        DateTime? FechaFin,
        Guid TipoTareaId,
        Guid EstadoTareaId,
        Guid PrioridadTareaId
    ): ICommand;
}
