using evaluacionUtcd.Domain.Modules.Factura.Projections.FacturaTable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace evaluacionUtcd.Data.Configurations;

public class DetalleFacturaConfiguration : IEntityTypeConfiguration<DetalleFactura>
{
    /// <summary>
    /// Método de configuración
    /// </summary>
    /// <param name="builder"></param>

    public void Configure(EntityTypeBuilder<DetalleFactura> builder)
    {
        builder.ToTable("detalle_factura", Environment.GetEnvironmentVariable("DB__SCHEMA_TABLES"));

        builder.HasKey(x=>x.Id);

    }
}
