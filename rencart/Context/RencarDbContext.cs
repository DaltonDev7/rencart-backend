using Microsoft.EntityFrameworkCore;
using rencart.ConfigurationEntity;
using rencart.Entities;

namespace rencart.Context
{
    public class RencarDbContext : DbContext
    {
        public RencarDbContext(DbContextOptions<RencarDbContext> options) : base(options)
        {
        }
        public RencarDbContext()
        {

        }
        public DbSet<firtstable> firtable { get; set; }
        public DbSet<TipoVehiculo> TipoVehiculo { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new firtstableConfiguration());
            builder.ApplyConfiguration(new TipoVehiculoConfiguration());
           
        }

    }
}
