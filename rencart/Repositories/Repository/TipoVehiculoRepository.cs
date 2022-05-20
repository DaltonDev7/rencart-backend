using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;

namespace rencart.Repositories.Repository
{
    public class TipoVehiculoRepository : BaseRepository<TipoVehiculo>, ITipoVehiculoRepository
    {
        public TipoVehiculoRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(TipoVehiculo tipoVehiculo)
        {
            throw new System.NotImplementedException();
        }
    }
}
