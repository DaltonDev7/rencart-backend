using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class VehiculoConfiguration : IEntityTypeConfiguration<Vehiculo>
    {
        public void Configure(EntityTypeBuilder<Vehiculo> builder)
        {
            builder.ToTable("Vehiculos");
            builder.HasKey(x => x.Id);

            builder.HasOne(v => v.TipoVehiculo)
                   .WithMany(t => t.Vehiculos)
                   .HasForeignKey(v => v.IdTipoVehiculo);

        }
    }
}
