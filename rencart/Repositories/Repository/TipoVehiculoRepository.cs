using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;
using System;

namespace rencart.Repositories.Repository
{
    public class TipoVehiculoRepository : BaseRepository<TipoVehiculo>, ITipoVehiculoRepository
    {
        public TipoVehiculoRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(TipoVehiculo tipoVehiculo)
        {
            var tipoVehiculoUpdate = Get(tipoVehiculo.Id);
            tipoVehiculoUpdate.Descripcion = tipoVehiculo.Descripcion;
            tipoVehiculoUpdate.Estado = tipoVehiculo.Estado;
            tipoVehiculoUpdate.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);
        }
    }
}
