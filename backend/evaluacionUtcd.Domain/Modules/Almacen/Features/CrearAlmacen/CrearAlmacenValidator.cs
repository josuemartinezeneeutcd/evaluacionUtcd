using Enee.Core.CQRS.Validation;
using FluentValidation;

namespace evaluacionUtcd.Domain.Modules.Almacen.Features.CrearAlmacen;

public class CrearAlmacenValidator:CommandValidatorBase<CrearAlmacenCommand>
{
    public CrearAlmacenValidator()
    {
        RuleFor(x => x.Id).NotEmpty().NotNull();
        RuleFor(x => x.NombreSucursal).NotEmpty().NotNull();
        RuleFor(x => x.NombreAdministrador).NotEmpty().NotNull();
        RuleFor(x => x.Telefono).NotEmpty().NotNull();
        RuleFor(x => x.Direccion).NotEmpty().NotNull();

    }

}
