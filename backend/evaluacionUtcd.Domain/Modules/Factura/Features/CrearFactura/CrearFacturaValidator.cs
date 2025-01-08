using Enee.Core.CQRS.Validation;
using FluentValidation;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.CrearFactura;

public class CrearFacturaValidator:CommandValidatorBase<CrearFacturaCommand>
{
    public CrearFacturaValidator()
    {
        RuleFor(x => x.Numero).NotEmpty();
    }
}
