using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using evaluacionUtcd.Domain.Modules.Tarea.Projections;

namespace evaluacionUtcd.Domain.Modules.Tarea.Features.ConsultarTareas
{
    public class ConsultarTareasPaginadoQuery : IPaginatedParams, IQuery<IPaginated<TareaTabla>>
    {
        public string Description { get; }
        public int? Page { get; set; }
        public int? PageSize { get; set; }
        public string? Nombre { get; set; }
        public string? Descripcion { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin {  get; set; }
    }
}
