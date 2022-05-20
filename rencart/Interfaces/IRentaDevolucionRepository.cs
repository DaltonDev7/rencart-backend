using rencart.Entities;

namespace rencart.Interfaces
{
    public interface IRentaDevolucionRepository : IBaseRepository<RentaDevolucion>
    {
        void Update(RentaDevolucion entity);
    }
}
