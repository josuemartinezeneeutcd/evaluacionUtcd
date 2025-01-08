using Enee.Core.CQRS.Command;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.EliminarFactura;

public record EliminarFacturaCommand(Guid Id):ICommand;
