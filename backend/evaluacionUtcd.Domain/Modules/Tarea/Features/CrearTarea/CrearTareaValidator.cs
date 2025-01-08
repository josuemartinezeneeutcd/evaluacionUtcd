
using Enee.Core.CQRS.Validation;
using Enee.Core.Domain.Repository;
using evaluacionUtcd.Domain.Modules.TipoTarea.Projections;
using FluentValidation;

namespace evaluacionUtcd.Domain.Modules.Tarea.Features.CrearTarea
{
    public class CrearTareaValidator : CommandValidatorBase<CrearTareaCommand>
    {
        public CrearTareaValidator()
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
