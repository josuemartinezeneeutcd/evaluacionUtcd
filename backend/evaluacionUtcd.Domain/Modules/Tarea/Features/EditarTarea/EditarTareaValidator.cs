using FluentValidation;
using Enee.Core.CQRS.Validation;

namespace evaluacionUtcd.Domain.Modules.Tarea.Features.EditarTarea
{
    internal class EditarTareaValidator: CommandValidatorBase<EditarTareaCommand>
    {
        public EditarTareaValidator()
        {
            RuleFor(x => x.Nombre)
                .NotEmpty()
                .NotNull()
                .WithMessage("Ingrese un nombre para la tarea");

            RuleFor(x => x.Descripcion)
                .NotEmpty()
                .NotNull()
                .WithMessage("Ingrese una descripción para la tarea");

            RuleFor(x => x.FechaInicio)
                .NotEmpty()
                .NotNull()
                .WithMessage("Ingrese una fecha de inicio válida");

            RuleFor(x => x.FechaFin)
                .GreaterThanOrEqualTo(x => x.FechaInicio)
                .When(x => x.FechaFin.HasValue)
                .WithMessage("La fecha de fin no puede ser anterior a la fecha de inicio");
        }
    }
}

