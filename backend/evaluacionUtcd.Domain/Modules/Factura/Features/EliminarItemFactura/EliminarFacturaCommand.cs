using Enee.Core.CQRS.Command;

namespace evaluacionUtcd.Domain.Modules.Factura.Features.EliminarItemFactura;

public class EliminarItemFacturaCommand(Guid facturaId,Guid itemId):ICommand
{
    public Guid FacturaId { get; set; } = facturaId;
    public Guid ItemId { get; set; } = itemId;
    
}