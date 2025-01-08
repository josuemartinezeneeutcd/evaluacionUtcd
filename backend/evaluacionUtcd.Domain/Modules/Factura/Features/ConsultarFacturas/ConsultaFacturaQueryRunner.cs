using Ardalis.Specification;
using Enee.Core.CQRS.Query;
using Enee.Core.Domain;
using Enee.Core.Domain.Repository;
using Enee.Core.Domain.Specs;
using evaluacionUtcd.Domain.Modules.Factura.Projections.FacturaTable;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.ConsultarFacturas;

public class ConsultaFacturaQueryRunner : IQueryRunner<ConsultarFacturaQuery, IPaginated<Facturas>>
{
    public IReadOnlyRepository<Facturas> Repository { get; }

    public ConsultaFacturaQueryRunner(IReadOnlyRepository<Facturas> repository)
    {
        Repository = repository;
    }

    public async Task<IPaginated<Facturas>> Run(ConsultarFacturaQuery query)
    {
    var spec = new SpecificationGeneric<Facturas>();
        spec.Query.Where(x => x.Numero.Contains(query.Filters.Numero),
            !string.IsNullOrWhiteSpace(query.Filters.Numero));
        spec.Query.OrderBy(x => x.CreatedDate);
        IPaginated<Facturas> paginated = await Repository.Paginate(query.Filters.Page, query.Filters.PageSize, spec);
        return paginated;


    }
}
