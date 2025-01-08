
using evaluacionUtcd.Domain.Modules.TipoTarea.Projections;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace evaluacionUtcd.Data.Configurations;
public class TipoTareaConfiguration : IEntityTypeConfiguration<TipoTareaTabla>
{
    /// <summary>
    /// Configuración de la entidad TipoTareaTabla
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<TipoTareaTabla> builder)
    {
        // Configura la tabla y el esquema
        builder.ToTable("tipo_tarea", Environment.GetEnvironmentVariable("DB__SCHEMA_TABLES"));

        // Configura la clave primaria
        builder.HasKey(x => x.Id);

    }
}
