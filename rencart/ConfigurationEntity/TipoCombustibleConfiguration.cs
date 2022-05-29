using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class TipoCombustibleConfiguration : IEntityTypeConfiguration<TipoCombustible>
    {
        public void Configure(EntityTypeBuilder<TipoCombustible> builder)
        {
            builder.ToTable("TipoCombustible");
            builder.HasKey(x => x.Id);
        }
    }
}
