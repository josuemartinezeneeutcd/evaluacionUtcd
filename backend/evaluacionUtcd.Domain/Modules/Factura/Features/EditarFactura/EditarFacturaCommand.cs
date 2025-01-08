using Enee.Core.CQRS.Command;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.EditarFactura;

public record EditarFacturaCommand(Guid Id, string Numero,DateOnly FechaEmision, string EstadoId):ICommand
{

}
