using rencart.Entities;
using System.Threading.Tasks;

namespace rencart.Interfaces
{
    public interface IVehiculoRepository : IBaseRepository<Vehiculo>
    {
        void Update(Vehiculo vehiculo);
        Task<dynamic> getVehiculos();
    }
}
