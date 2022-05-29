using rencart.Entities;
using System.Threading.Tasks;

namespace rencart.Interfaces
{
    public interface IInspeccionRepository : IBaseRepository<Inspeccion>
    {
        void Update(Inspeccion inspeccion);

        void RemoveInspeccion(Inspeccion inspeccion);
        Task<dynamic> verificarInspeccionVehiculo(int idVehiculo);
        Task<dynamic> getAllInspecciones();
    }
}
