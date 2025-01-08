
using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using evaluacionUtcd.Domain.Modules.Tarea.Aggregates;

namespace evaluacionUtcd.Domain.Modules.Tarea.Features.EditarTarea
{
    public class EditarTareaHandler : ICommandHandler<EditarTareaCommand>
    {
        public IWritableEventStoreRepository<TareaRoot> _tareaRepository { get; }

        public EditarTareaHandler(IWritableEventStoreRepository<TareaRoot> TareaRepository)
        {
            _tareaRepository = TareaRepository;
        }

        public async Task Handle(EditarTareaCommand command)
        {
            var tarea = await _tareaRepository.Find(command.Id);


            tarea.Editar(
                command.Id,
                command.Nombre,
                command.Descripcion,
                command.FechaInicio,
                command.FechaFin,
                command.TipoTareaId,
                command.EstadoTareaId,
                command.PrioridadTareaId
            );

            await _tareaRepository.Update(tarea);
        }
    }
}
