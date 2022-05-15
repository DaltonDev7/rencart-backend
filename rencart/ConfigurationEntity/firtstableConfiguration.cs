using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class firtstableConfiguration : IEntityTypeConfiguration<firtstable>
    {
        public void Configure(EntityTypeBuilder<firtstable> builder)
        {
            builder.ToTable("PrimeraTabla");
            builder.HasKey(x => x.Id);
        }
    }
}
