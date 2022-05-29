using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class MarcaConfiguration : IEntityTypeConfiguration<Marca>
    {
        public void Configure(EntityTypeBuilder<Marca> builder)
        {
            builder.ToTable("Marcas");
            builder.HasKey(x => x.Id);
        }
    }
}
