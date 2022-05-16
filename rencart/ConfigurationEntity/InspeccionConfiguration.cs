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
        }
    }
}
