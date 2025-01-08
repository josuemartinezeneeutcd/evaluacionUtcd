using Enee.Core.Common;

namespace evaluacionUtcd.Domain.Modules.Almacen.Features.EliminarAlmacen;

public class AlmacenEliminado:DomainEvent<Guid>
{
    public AlmacenEliminado(Guid aggregateId) : base(aggregateId)
    {
    }
}
