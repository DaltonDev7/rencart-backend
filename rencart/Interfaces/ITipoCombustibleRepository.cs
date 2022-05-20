using rencart.Entities;

namespace rencart.Interfaces
{
    public interface ITipoCombustibleRepository : IBaseRepository<TipoCombustible>
    {
        void Update(TipoCombustible tipoCombustible);
    }
}
