﻿using Enee.Core.Events;

namespace evaluacionUtcd.Domain.Modules.Almacen.Events.AlmacenCreado;

public class CrearCuentaAnaliticaEnOdoo:IEventHandler<Features.CrearAlmacen.AlmacenCreado>
{
    public Task Handle(Features.CrearAlmacen.AlmacenCreado @event)
    {
        Console.WriteLine("Cuenta de almance creada en odoo");
        return Task.CompletedTask;
    }
}
