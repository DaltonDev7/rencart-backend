using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class ClienteConfiguration : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(x => x.Id);

            builder.HasOne(v => v.TipoPersona)
                  .WithMany(t => t.Clientes)
                  .HasForeignKey(v => v.IdTipoPersona)
                  .OnDelete(DeleteBehavior.ClientSetNull);

           builder.HasIndex(x => x.Cedula).IsUnique();


        }
    }
}
