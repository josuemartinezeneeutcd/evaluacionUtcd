
using Enee.Core.CQRS.Validation;
using Enee.Core.Domain.Repository;
using evaluacionUtcd.Domain.Modules.TipoTarea.Projections;
using FluentValidation;

namespace evaluacionUtcd.Domain.Modules.Tarea.Features.CrearTarea
{
    public class CrearTareaValidator : CommandValidatorBase<CrearTareaCommand>
    {
        //   private IReadOnlyRepository<TipoTareaTabla> TipoTareaRepository { get;}
        //private IReadOnlyRepository<EstadoTarea> EstadoTareaRepository { get; set; }
        // private IReadOnlyRepository<PrioridadTarea> PrioridadTareaRepository { get; set; }

        public CrearTareaValidator(/*
            IReadOnlyRepository<TipoTarea> tipoTareaRepository,
            IReadOnlyRepository<EstadoTarea> estadoTareaRepository,
            IReadOnlyRepository<PrioridadTarea> prioridadTareaRepository*/
        )
        {
            //TipoTareaRepository = tipoTareaRepository;
            //EstadoTareaRepository = estadoTareaRepository;
            //PrioridadTareaRepository = prioridadTareaRepository;

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
            /*
            RuleFor(x => x.TipoTareaId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Ingrese un tipo de tarea")
                .Custom(ExisteTipoTarea);

            RuleFor(x => x.EstadoTareaId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Ingrese un estado de tarea")
                .Custom(ExisteEstadoTarea);

            RuleFor(x => x.PrioridadTareaId)
                .NotEmpty()
                .NotNull()
                .WithMessage("Ingrese una prioridad de tarea")
                .Custom(ExistePrioridadTarea);

            */
        }
        /*
        private void ExisteTipoTarea(Guid id, ValidationContext<CrearTareaCommand> context)
        {
            bool existe = TipoTareaRepository.AsQueryable().Any(x => x.Id == id);
            if (!existe)
            {
                context.AddFailure("El tipo de tarea no existe");
            }
        }

        private void ExisteEstadoTarea(Guid id, ValidationContext<CrearTareaCommand> context)
        {
            bool existe = EstadoTareaRepository.AsQueryable().Any(x => x.Id == id);
            if (!existe)
            {
                context.AddFailure("El estado de tarea no existe");
            }
        }

        private void ExistePrioridadTarea(Guid id, ValidationContext<CrearTareaCommand> context)
        {
            bool existe = PrioridadTareaRepository.AsQueryable().Any(x => x.Id == id);
            if (!existe)
            {
                context.AddFailure("La prioridad de tarea no existe");
            }
        }

        */
    }
}
