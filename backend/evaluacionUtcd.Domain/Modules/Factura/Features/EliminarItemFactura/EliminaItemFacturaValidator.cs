using Enee.Core.CQRS.Validation;
using FluentValidation;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.EliminarItemFactura;

public class EliminaItemFacturaValidator:CommandValidatorBase<EliminarItemFacturaCommand>    
{
    public EliminaItemFacturaValidator()
    {
        RuleFor(x => x.ItemId).NotEmpty();
        RuleFor(x => x.FacturaId).NotEmpty();
    }
}