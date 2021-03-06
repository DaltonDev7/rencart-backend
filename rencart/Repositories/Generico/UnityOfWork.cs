using rencart.Context;
using rencart.Interfaces;
using rencart.Repositories.Repository;
using System;

namespace rencart.Repositories.Generico
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        private readonly RencarDbContext _dbContext;
        public UnityOfWork(RencarDbContext dbContext)
        {
            _dbContext = dbContext;

            //Inicializamo los repositorios y le pasamos el context al contructor de los repositorios
            Marcas = new MarcaRepository(_dbContext);
            Modelos = new ModeloRepository(_dbContext);
            TipoVehiculos = new TipoVehiculoRepository(_dbContext);
            TipoCombustible = new TipoCombustibleRepository(_dbContext);
            vehiculo = new VehiculoRepository(_dbContext);
            TipoPersona = new TipoPersonaRepository(_dbContext);
            Cliente = new ClienteRepository(_dbContext);
            Empleado = new EmpleadoRepository(_dbContext);
            Inspeccion = new InspeccionRepository(_dbContext);
            RentaDevolucion = new RentaDevolucionRepository(_dbContext);
        }

        public IMarcaRepository Marcas { get; private set; }

        public IModeloRepository Modelos { get; private set; }

        public ITipoVehiculoRepository TipoVehiculos { get; private set; }

        public ITipoCombustibleRepository TipoCombustible { get; private set; }

        public IVehiculoRepository vehiculo { get; private set; }

        public ITipoPersonaRepository TipoPersona { get; private set; }

        public IClienteRepository Cliente { get; private set; }

        public IEmpleadoRepository Empleado { get; private set; }

        public IInspeccionRepository Inspeccion { get; private set; }

        public IRentaDevolucionRepository RentaDevolucion { get; private set; }

        public int Complete()
        {
            return _dbContext.SaveChanges();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
