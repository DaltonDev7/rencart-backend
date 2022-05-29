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

        public void Update(TipoCombustible tipoCombustible)
        {
            var updateTipoCombustible = Get(tipoCombustible.Id);
            updateTipoCombustible.Descripcion = tipoCombustible.Descripcion;
            updateTipoCombustible.Estado = tipoCombustible.Estado;
            updateTipoCombustible.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);
        }

 
    }
}
