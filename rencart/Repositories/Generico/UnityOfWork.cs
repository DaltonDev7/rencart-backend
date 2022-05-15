using rencart.Context;
using rencart.Interfaces;
using System;

namespace rencart.Repositories.Generico
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly RencarDbContext _dbContext;
        public UnityOfWork(RencarDbContext dbContext)
        {
            //Inicializamo los repositorios y le pasamos el context al contructor de los repositorios

        }

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
