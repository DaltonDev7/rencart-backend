using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;

namespace rencart.Repositories.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }
    }
}
