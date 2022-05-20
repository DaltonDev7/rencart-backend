using rencart.Entities;

namespace rencart.Interfaces
{
    public interface IMarcaRepository : IBaseRepository<Marca>
    {
        public void Update(Marca marca);
    }
}
