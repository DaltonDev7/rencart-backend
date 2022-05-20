using rencart.Entities;

namespace rencart.Interfaces
{
    public interface IVehiculoRepository : IBaseRepository<Vehiculo>
    {
        void Update(Vehiculo vehiculo);
    }
}
