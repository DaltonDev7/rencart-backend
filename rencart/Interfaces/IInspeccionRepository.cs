using rencart.Entities;

namespace rencart.Interfaces
{
    public interface IInspeccionRepository : IBaseRepository<Inspeccion>
    {
        void Update(Inspeccion inspeccion);
    }
}
