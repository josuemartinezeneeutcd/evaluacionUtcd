using Enee.Core.Common;

namespace evaluacionUtcd.Domain.Modules.Tarea.Features.CrearTarea
{
    public class TareaCreada : DomainEvent<Guid>
    {
        public TareaCreada(
            Guid aggregateId,
            string nombre,
            string descripcion,
            DateTime fechaInicio,
            DateTime? fechaFin,
            Guid tipoTareaId,
            Guid estadoTareaId,
            Guid prioridadTareaId
        )
            : base(aggregateId)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            FechaInicio = fechaInicio;
            FechaFin = fechaFin;
            TipoTareaId = tipoTareaId;
            EstadoTareaId = estadoTareaId;
            PrioridadTareaId = prioridadTareaId;
        }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public Guid TipoTareaId { get; set; }

        public Guid EstadoTareaId { get; set; }

        public Guid PrioridadTareaId { get; set; }
    }
}
