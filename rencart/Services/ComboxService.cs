using Microsoft.EntityFrameworkCore;
using rencart.Context;
using rencart.Interfaces.Services;
using System.Linq;
using System.Threading.Tasks;

namespace rencart.Services
{
    public class ComboxService : IComboxService
    {
        public RencarDbContext _context;

        public ComboxService(RencarDbContext context)
        {
            _context=context;
        }

        public async Task<dynamic> getClienteCombox()
        {
            return await _context.Cliente.Select(c => new
            {
                id = c.Id,
                text = c.Nombres+" "+ c.Apellidos
            }).ToListAsync();
        }
        public async Task<dynamic> getTipoPersonaCombox()
        {
            return await _context.TipoPersona.Select(c => new
            {
                id = c.Id,
                text = c.Descripcion
            }).ToListAsync();
        }

        public async Task<dynamic> getMarcaCombox()
        {
            return await _context.Marca.Select(m => new
            {
                id = m.Id,
                text = m.Descripcion
            }).ToListAsync();
        }

        public async Task<dynamic> getModeloCombox()
        {
            return await _context.Modelo.Select(m => new
            {
                id = m.Id,
                text = m.Descripcion
            }).ToListAsync();
        }

        public async Task<dynamic> getTipoCombustibleCombox()
        {
            return await _context.TipoCombustible.Select(m => new
            {
                id = m.Id,
                text = m.Descripcion
            }).ToListAsync();
        }

        public async Task<dynamic> getEmpleadoCombox()
        {
            return await _context.Empleado.Select(m => new
            {
                id = m.Id,
                text = m.Nombres+" "+m.Apellidos
            }).ToListAsync();
        }

        public async Task<dynamic> getTipoVehiculoCombox()
        {
            return await _context.TipoVehiculo.Select(m => new
            {
                id = m.Id,
                text = m.Descripcion
            }).ToListAsync();
        }

        public async Task<dynamic> getVehiculoCombox()
        {
            return await _context.Vehiculo.Select(m => new
            {
                id = m.Id,
                text = m.Descripcion
            }).ToListAsync();
        }

        public async Task<dynamic> getModelosByIdMarca(int idMarca)
        {
            return await _context.Modelo.Select(m => new
            {
                id = m.Id,
                text = m.Descripcion,
                m.IdMarca
            }).Where(m => m.IdMarca == idMarca).ToListAsync();
        }

    }
}
