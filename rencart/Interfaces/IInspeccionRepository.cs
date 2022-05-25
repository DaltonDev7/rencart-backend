using rencart.Entities;
using System.Threading.Tasks;

namespace rencart.Interfaces
{
    public interface IInspeccionRepository : IBaseRepository<Inspeccion>
    {
        void Update(Inspeccion inspeccion);

        Task<dynamic> getAllInspecciones();
    }
}
