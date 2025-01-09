using evaluacionUtcd.Domain.Modules.Tarea.Projections;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using evaluacionUtcd.Domain.Modules.TipoTarea.Projections;

namespace evaluacionUtcd.Data.Configurations;
public class TareaConfiguration : IEntityTypeConfiguration<TareaTabla>
{
    /// <summary>
    /// Configuración de la entidad Tarea
    /// </summary>
    /// <param name="builder"></param>
    public void Configure(EntityTypeBuilder<TareaTabla> builder)
    {
        builder.ToTable("tarea", Environment.GetEnvironmentVariable("DB__SCHEMA_TABLES"));

        builder.HasKey(x => x.Id);

        builder
            .HasOne<TipoTareaTabla>(x => x.TipoTarea)
            .WithMany(x => x.Tareas)
            .HasForeignKey(x => x.TipoTareaId)
            .IsRequired();


        builder
            .HasOne<EstadoTareaTabla>(x => x.EstadoTarea)
            .WithMany(x => x.Tareas)
            .HasForeignKey(x => x.EstadoTareaId)
            .IsRequired();


        builder
            .HasOne<PrioridadTareaTabla>(x => x.PrioridadTarea)
            .WithMany(x => x.Tareas)
            .HasForeignKey(x => x.PrioridadTareaId)
            .IsRequired();

    }
}
