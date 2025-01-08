using Enee.Core.CQRS.Command;

namespace evaluacionUtcd.Domain.Modules.Almacen.Features.EliminarAlmacen;

public record EliminarAlmacenCommand(Guid Id) : ICommand;
