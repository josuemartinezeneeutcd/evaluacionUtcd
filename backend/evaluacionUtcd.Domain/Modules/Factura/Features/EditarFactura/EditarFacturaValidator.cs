using Enee.Core.CQRS.Validation;
using evaluacionUtcd.Domain.Modules.Factura.Features.CrearFactura;
using FluentValidation;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.EditarFactura;

public class EditarFacturaValidator:CommandValidatorBase<EditarFacturaCommand>
{
    public EditarFacturaValidator()
    {
        RuleFor(x=>x.Id).NotEmpty();
        RuleFor(x => x.Numero).NotEmpty();
        RuleFor(x => x.FechaEmision).NotNull();
        RuleFor(x => x.EstadoId).NotEmpty();
    }
}
