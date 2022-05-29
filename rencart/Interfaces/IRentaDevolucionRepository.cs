using rencart.DTO;
using rencart.Entities;
using System.Threading.Tasks;

namespace rencart.Interfaces
{
    public interface IRentaDevolucionRepository : IBaseRepository<RentaDevolucion>
    {

        Task<dynamic> getRentas();
        Task<dynamic> Update(UpdateRentaDTO data);
        void updateRentaActual(RentaDevolucion renta);
        Task<dynamic> buscador(BuscadorDTO payload);
        Task<dynamic> verificarRentaDisponible(RentaDisponibleDTO payload);
    }
}
