using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using rencart.Entities;

namespace rencart.ConfigurationEntity
{
    public class EmpleadoConfiguration : IEntityTypeConfiguration<Empleado>
    {
        public void Configure(EntityTypeBuilder<Empleado> builder)
        {
            builder.ToTable("Empleados");
            builder.HasKey(x => x.Id);

            builder.HasIndex(x => x.Cedula).IsUnique();
        }
    }
}
