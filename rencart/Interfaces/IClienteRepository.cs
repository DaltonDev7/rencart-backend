using rencart.Entities;
using System.Threading.Tasks;

namespace rencart.Interfaces
{
    public interface IClienteRepository : IBaseRepository<Cliente>
    {
        void Update(Cliente cliente);
        Task<dynamic> getClientes();
    }
}
