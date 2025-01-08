using System.ComponentModel.DataAnnotations;

namespace evaluacionUtcd.Api.Modules.Tarea.Common
{
    public class TareaRequest
    {
        [Required]
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        [Required]
        public DateTime FechaInicio { get; set; }

        public DateTime? FechaFin { get; set; }

        [Required]
        public Guid TipoTareaId { get; set; }

        [Required]
        public Guid EstadoTareaId { get; set; }

        [Required]
        public Guid PrioridadTareaId { get; set; }
    }
}
