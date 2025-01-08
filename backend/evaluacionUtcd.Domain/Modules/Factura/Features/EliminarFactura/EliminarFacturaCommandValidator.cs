using Enee.Core.CQRS.Validation;
using FluentValidation;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.EliminarFactura;

public class EliminarFacturaCommandValidator:CommandValidatorBase<EliminarFacturaCommand>
{
    public EliminarFacturaCommandValidator()
    {
        RuleFor(x=>x.Id).NotEmpty().NotNull();
    }

}
