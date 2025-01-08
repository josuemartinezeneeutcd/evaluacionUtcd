using Enee.Core.CQRS.Command;
using Enee.Core.Domain.Repository;
using evaluacionUtcd.Domain.Modules.Tarea.Aggregates;
namespace evaluacionUtcd.Domain.Modules.Tarea.Features.CrearTarea
{
    public class CrearTareaHandler : ICommandHandler<CrearTareaCommand>
    {
        private IWritableEventStoreRepository<TareaRoot> _tareaRepository { get; }

        public CrearTareaHandler(IWritableEventStoreRepository<TareaRoot> tareaRepository)
        {
            _tareaRepository = tareaRepository;
        }

        public async Task Handle(CrearTareaCommand command)
        {

            var tarea = new TareaRoot(
                command.Id,
                command.Nombre,
                command.Descripcion,
                command.FechaInicio,
                command.FechaFin,
                command.TipoTareaId,
                command.EstadoTareaId,
                command.PrioridadTareaId
            );


            await _tareaRepository.Create(tarea);
        }
    }
}
