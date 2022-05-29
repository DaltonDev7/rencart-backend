using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class ModeloConfiguration : IEntityTypeConfiguration<Modelo>
    {
        public void Configure(EntityTypeBuilder<Modelo> builder)
        {
            builder.ToTable("Modelos");
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Marca)
                   .WithMany(x => x.Modelos)
                   .HasForeignKey( x => x.IdMarca)
                   .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
