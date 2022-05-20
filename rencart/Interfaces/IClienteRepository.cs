using rencart.Entities;

namespace rencart.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        void Update(Cliente cliente);
    }
}
