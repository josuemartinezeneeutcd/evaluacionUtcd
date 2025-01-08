using Enee.Core.CQRS.Query;
using evaluacionUtcd.Domain.Modules.Tarea.Features.CrearTarea;
using evaluacionUtcd.Domain.Modules.Tarea.Features.EditarTarea;

namespace evaluacionUtcd.Domain.Modules.Tarea.Projections
{
    public class TareaProjector : TableProjector<TareaTabla>
    {
        public TareaProjector()
        {
            Create<TareaCreada>(
                (@event, entity) =>
                {
                    entity.Id = @event.AggregateId;
                    entity.Nombre = @event.Nombre;
                    entity.Descripcion = @event.Descripcion;
                    entity.FechaInicio = @event.FechaInicio;
                    entity.FechaFin = @event.FechaFin;
                    entity.TipoTareaId = @event.TipoTareaId;
                    entity.EstadoTareaId = @event.EstadoTareaId;
                    entity.PrioridadTareaId = @event.PrioridadTareaId;
                }
            );

            Project<TareaEditada>(
            (@event, entity) =>
            {
                entity.Id = @event.AggregateId;
                entity.Nombre = @event.Nombre;
                entity.Descripcion = @event.Descripcion;
                entity.FechaInicio = @event.FechaInicio;
                entity.FechaFin = @event.FechaFin;
                entity.TipoTareaId = @event.TipoTareaId;
                entity.EstadoTareaId = @event.EstadoTareaId;
                entity.PrioridadTareaId = @event.PrioridadTareaId;
            }
        );


        }
    }
}
