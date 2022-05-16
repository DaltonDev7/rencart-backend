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
        }
    }
}
