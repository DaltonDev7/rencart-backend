using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class RentaDevolucionConfiguration : IEntityTypeConfiguration<RentaDevolucion>
    {
        public void Configure(EntityTypeBuilder<RentaDevolucion> builder)
        {
            builder.ToTable("RentaDevolucion");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Empleado)
                  .WithMany(x => x.RentaDevolucion)
                  .HasForeignKey(x => x.IdEmpleado)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Cliente)
                  .WithMany(x => x.RentaDevolucion)
                  .HasForeignKey(x => x.IdCliente)
                  .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasOne(x => x.Vehiculo)
                  .WithMany(x => x.RentaDevolucion)
                  .HasForeignKey(x => x.IdVehiculo)
                  .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
