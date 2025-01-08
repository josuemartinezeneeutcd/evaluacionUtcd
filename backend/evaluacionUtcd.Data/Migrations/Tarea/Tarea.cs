using Enee.IoC.Architecture;
using FluentMigrator;
using Microsoft.Extensions.Options;

namespace UtcdRefacturacion.Data.Migrations;

[Migration(202501081030)]
public class AgregarTablaTarea(IOptions<DbSettings> dbSetting) : Migration
{
    private const string NOMBRE_TABLA_TAREA = "Tarea";

    public override void Up()
    {
        var db = dbSetting.Value;

        Create
            .Table(NOMBRE_TABLA_TAREA)
            .InSchema(db.SchemaTables)
            .WithColumn("Id")
            .AsGuid()
            .PrimaryKey()
            .WithColumn("Nombre")
            .AsString(200)
            .NotNullable()
            .WithColumn("Descripcion")
            .AsString(1000)
            .Nullable()
            .WithColumn("FechaInicio")
            .AsDate()
            .NotNullable()
            .WithColumn("FechaFin")
            .AsDate()
            .Nullable()
            .WithColumn("TipoTareaId")
            .AsGuid()
            .NotNullable()
            .ForeignKey("TipoTarea", "Id")
            .WithColumn("EstadoTareaId")
            .AsGuid()
            .NotNullable()
            .ForeignKey("EstadoTarea", "Id")
            .WithColumn("PrioridadTareaId")
            .AsGuid()
            .NotNullable()
            .ForeignKey("PrioridadTarea", "Id");
    }

    public override void Down()
    {
        var db = dbSetting.Value;

        Delete.Table(NOMBRE_TABLA_TAREA).IfExists().InSchema(db.SchemaTables);
    }
}
