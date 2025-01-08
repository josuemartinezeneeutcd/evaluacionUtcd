using evaluacionUtcd.Domain.Modules.Tarea.Projections;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace evaluacionUtcd.Data.Configurations;
public class TareaConfiguration : IEntityTypeConfiguration<TareaTabla>
{
    /// <summary>
    /// Configuración de la entidad Tarea
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<TareaTabla> builder)
    {
        // Configura la tabla y el esquema
        builder.ToTable("tarea", Environment.GetEnvironmentVariable("DB__SCHEMA_TABLES"));

        // Configura la clave primaria
        builder.HasKey(x => x.Id);

    }
}
