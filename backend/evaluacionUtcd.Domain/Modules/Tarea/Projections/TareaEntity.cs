using Enee.Core.Common;
using evaluacionUtcd.Domain.Modules.TipoTarea.Projections;

namespace evaluacionUtcd.Domain.Modules.Tarea.Projections
{
    public class TareaTabla : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        public Guid TipoTareaId { get; set; }

        public Guid EstadoTareaId { get; set; }

        public Guid PrioridadTareaId { get; set; }

       public TipoTareaTabla? TipoTarea { get; set; }
       public EstadoTareaTabla? EstadoTarea { get; set; }
       public PrioridadTareaTabla? PrioridadTarea { get; set; }

    }
}
