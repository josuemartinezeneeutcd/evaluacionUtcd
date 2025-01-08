using System.Data;
using Ardalis.Specification;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using evaluacionUtcd.Domain.Modules.Tarea.Projections;
namespace evaluacionUtcd.Domain.Modules.Tarea.Features.ConsultarTareas
{
    public class ConsultarTareasPaginadoRunner
     : IQueryRunner<ConsultarTareasPaginadoQuery, IPaginated<TareaTabla>>
    {
        public IReadOnlyRepository<TareaTabla> Repository { get; }

        public ConsultarTareasPaginadoRunner(IReadOnlyRepository<TareaTabla> repository)
        {
            Repository = repository;
        }

        public async Task<IPaginated<TareaTabla>> Run(ConsultarTareasPaginadoQuery query)
        {
            var spec = new SpecificationGeneric<TareaTabla>();

            if (!string.IsNullOrEmpty(query.Nombre))
            {
                spec.Query.Where(p => p.Nombre.Contains(query.Nombre));
            }

            var paginated = await Repository.Paginate(query.Page, query.PageSize, spec);

            if (paginated == null)
            {
                throw new DataException("Tareas no encontradas");
            }

            return paginated;
        }
    }
}
