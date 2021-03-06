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
        public DbSet<Marca> Marca { get; set; }
        public DbSet<Modelo> Modelo { get; set; }
        public DbSet<TipoCombustible> TipoCombustible { get; set; }
        public DbSet<Vehiculo> Vehiculo { get; set; }
        public DbSet<TipoPersona> TipoPersona { get; set; }
        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Inspeccion> Inspeccion { get; set; }
        public DbSet<RentaDevolucion> RentaDevolucion { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new firtstableConfiguration());
            builder.ApplyConfiguration(new TipoVehiculoConfiguration());
            builder.ApplyConfiguration(new MarcaConfiguration());
            builder.ApplyConfiguration(new ModeloConfiguration());
            builder.ApplyConfiguration(new TipoCombustibleConfiguration());
            builder.ApplyConfiguration(new VehiculoConfiguration());
            builder.ApplyConfiguration(new TipoPersonaConfiguration());
            builder.ApplyConfiguration(new ClienteConfiguration());
            builder.ApplyConfiguration(new EmpleadoConfiguration());
            builder.ApplyConfiguration(new InspeccionConfiguration());
            builder.ApplyConfiguration(new RentaDevolucionConfiguration());
           
        }

    }
}
