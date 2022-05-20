using rencart.Entities;

namespace rencart.Interfaces
{
    public interface ITipoVehiculoRepository : IBaseRepository<TipoVehiculo>
    {
        void Update(TipoVehiculo tipoVehiculo);
    }
}
