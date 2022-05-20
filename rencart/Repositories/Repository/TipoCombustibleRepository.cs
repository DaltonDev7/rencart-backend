using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;
using System;


namespace rencart.Repositories.Repository
{
    public class TipoCombustibleRepository : BaseRepository<TipoCombustible>, ITipoCombustibleRepository
    {
        public TipoCombustibleRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(Entities.TipoCombustible tipoCombustible)
        {
            throw new NotImplementedException();
        }

 
    }
}
