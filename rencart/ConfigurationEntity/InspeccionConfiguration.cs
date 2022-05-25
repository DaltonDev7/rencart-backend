using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class InspeccionConfiguration : IEntityTypeConfiguration<Inspeccion>
    {
        public void Configure(EntityTypeBuilder<Inspeccion> builder)
        {
            builder.ToTable("Inspeccion");
            builder.HasKey(x => x.Id);

            builder.HasOne(v => v.Vehiculo)
                .WithMany(v => v.Inspecciones)
                .HasForeignKey(v => v.IdVehiculo)
                .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(i => i.Empleado)
               .WithMany(e => e.Inspecciones)
               .HasForeignKey(i => i.IdEmpleado)
               .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(i => i.Cliente)
                .WithMany(v => v.Inspecciones)
                .HasForeignKey(v => v.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
