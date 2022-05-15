using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class TipoVehiculoConfiguration : IEntityTypeConfiguration<TipoVehiculo>
    {
        public void Configure(EntityTypeBuilder<TipoVehiculo> builder)
        {
            builder.ToTable("TipoVehiculo");
            builder.HasKey(x => x.Id);
        }
    }
}
