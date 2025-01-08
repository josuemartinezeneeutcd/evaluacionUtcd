using Enee.Core.Domain;
using evaluacionUtcd.Domain.Modules.Tarea.Features.CrearTarea;
using evaluacionUtcd.Domain.Modules.Tarea.Features.EditarTarea;

namespace evaluacionUtcd.Domain.Modules.Tarea.Aggregates
{
    public class TareaRoot : AggregateRoot<Guid>
    {
        public TareaRoot() { }
  
        public TareaRoot(
             Guid id,
             string nombre,
             string descripcion,
             DateTime fechaInicio,
             DateTime? fechaFin,
             Guid tipoTareaId,
             Guid estadoTareaId,
             Guid prioridadTareaId
         )
        {
            Apply(
                NewChange(
                    new TareaCreada(
                        id,
                        nombre,
                        descripcion,
                        fechaInicio,
                        fechaFin,
                        tipoTareaId,
                        estadoTareaId,
                        prioridadTareaId
                    )
                )
            );
        }

        private void Apply(TareaCreada @event)
        {
            Id = @event.AggregateId;
            Nombre = @event.Nombre;
            Descripcion = @event.Descripcion;
            FechaInicio = @event.FechaInicio;
            FechaFin = @event.FechaFin;
            TipoTareaId = @event.TipoTareaId;
            EstadoTareaId = @event.EstadoTareaId;
            PrioridadTareaId = @event.PrioridadTareaId;
            Version++;
        }


        public override Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime? FechaFin { get; set; }
        public Guid TipoTareaId { get; set; }
        public Guid EstadoTareaId { get; set; }
        public Guid PrioridadTareaId { get; set; }

        private void Apply(TareaEditada @event)
        {
            Id = @event.AggregateId;
            Nombre = @event.Nombre;
            Descripcion = @event.Descripcion;
            FechaInicio = @event.FechaInicio;
            FechaFin = @event.FechaFin;
            TipoTareaId = @event.TipoTareaId;
            EstadoTareaId = @event.EstadoTareaId;
            PrioridadTareaId = @event.PrioridadTareaId;
            Version++;
        }

        public void Editar(
            Guid id,
            string nombre,
            string descripcion,
            DateTime fechaInicio,
            DateTime? fechaFin,
            Guid tipoTareaId,
            Guid estadoTareaId,
            Guid prioridadTareaId
        )
        {
            var tareaEditada = new TareaEditada(
                id,
                nombre,
                descripcion,
                fechaInicio,
                fechaFin,
                tipoTareaId,
                estadoTareaId,
                prioridadTareaId
            );
            Apply(NewChange(tareaEditada));
        }

    }
}
