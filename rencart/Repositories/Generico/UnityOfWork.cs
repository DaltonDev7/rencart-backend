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
        }

        public IMarcaRepository Marcas { get; private set; }

        public IModeloRepository Modelos { get; private set; }

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
