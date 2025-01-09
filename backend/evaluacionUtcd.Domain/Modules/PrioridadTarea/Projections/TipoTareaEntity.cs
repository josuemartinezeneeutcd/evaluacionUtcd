using Enee.Core.Common;
using evaluacionUtcd.Domain.Modules.Tarea.Projections;

namespace evaluacionUtcd.Domain.Modules.TipoTarea.Projections
{
    public class PrioridadTareaTabla : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public string Nombre { get; set; }
        public ICollection<TareaTabla> Tareas { get; } = new List<TareaTabla>();
    }

}

