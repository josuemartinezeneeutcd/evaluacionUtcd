using FluentMigrator;
using Microsoft.Extensions.Options;
using Enee.IoC.Architecture;

namespace UtcdRefacturacion.Data.Migrations;

[Migration(202501081020)]
public class AgregarParametrosAuxiliares(IOptions<DbSettings> dbSetting) : Migration
{
    private const string NOMBRE_TABLA_TIPO_TAREA = "TipoTarea";
    private const string NOMBRE_TABLA_ESTADO_TAREA = "EstadoTarea";
    private const string NOMBRE_TABLA_PRIORIDAD_TAREA = "PrioridadTarea";

    public override void Up()
    {
        var db = dbSetting.Value;

        Create
            .Table(NOMBRE_TABLA_TIPO_TAREA)
            .InSchema(db.SchemaTables)
            .WithColumn("Id")
            .AsGuid()
            .PrimaryKey()
            .WithColumn("Nombre")
            .AsString(100)
            .NotNullable();

        Create
            .Table(NOMBRE_TABLA_ESTADO_TAREA)
            .InSchema(db.SchemaTables)
            .WithColumn("Id")
            .AsGuid()
            .PrimaryKey()
            .WithColumn("Nombre")
            .AsString(100)
            .NotNullable();

        Create
            .Table(NOMBRE_TABLA_PRIORIDAD_TAREA)
            .InSchema(db.SchemaTables)
            .WithColumn("Id")
            .AsGuid()
            .PrimaryKey()
            .WithColumn("Nombre")
            .AsString(100)
            .NotNullable();
    }

    public override void Down()
    {
        var db = dbSetting.Value;

        Delete.Table(NOMBRE_TABLA_PRIORIDAD_TAREA).IfExists().InSchema(db.SchemaTables);
        Delete.Table(NOMBRE_TABLA_ESTADO_TAREA).IfExists().InSchema(db.SchemaTables);
        Delete.Table(NOMBRE_TABLA_TIPO_TAREA).IfExists().InSchema(db.SchemaTables);
    }
}
