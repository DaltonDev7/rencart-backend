using Microsoft.EntityFrameworkCore;
using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;
using System.Linq;
using System.Threading.Tasks;

namespace rencart.Repositories.Repository
{
    public class ClienteRepository : BaseRepository<Cliente>, IClienteRepository
    {
        public RencarDbContext _context { get { return context; } }
        public ClienteRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(Cliente cliente)
        {
            var updateCliente = Get(cliente.Id);
            updateCliente.Nombres = cliente.Nombres;
            updateCliente.Apellidos = cliente.Apellidos;
            updateCliente.NoTarjetaCR = cliente.NoTarjetaCR;
            updateCliente.LimiteCredito = cliente.LimiteCredito;
            updateCliente.Estado = cliente.Estado;
            updateCliente.Cedula = cliente.Cedula;
            updateCliente.IdTipoPersona = cliente.IdTipoPersona;
        }

        public async Task<dynamic> getClientes()
        {
            return await _context.Cliente.Select(c => new
            {
                c.Id,
               c.Nombres,
               c.Apellidos,
               c.Cedula,
               c.NoTarjetaCR,
               c.LimiteCredito,
               TipoPersona = c.TipoPersona.Descripcion
            }).ToListAsync();
        }
    }
}
