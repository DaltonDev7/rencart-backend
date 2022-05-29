using rencart.Entities;

namespace rencart.Interfaces
{
    public interface IMarcaRepository : IBaseRepository<Marca>
    {
        void Update(Marca marca);
    }
}
