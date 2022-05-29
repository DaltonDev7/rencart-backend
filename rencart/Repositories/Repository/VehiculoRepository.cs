using Microsoft.EntityFrameworkCore;
using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace rencart.Repositories.Repository
{
    public class VehiculoRepository : BaseRepository<Vehiculo>, IVehiculoRepository
    {
        public RencarDbContext _context { get { return context; } }
        public VehiculoRepository(RencarDbContext context) : base(context)
        {
        }

        public async Task<dynamic> getVehiculos()
        {
            return await _context.Vehiculo.Select(v => new
            {
                v.Id,
                v.NoChasis,
                v.NoMotor,
                TipoVehiculo = v.TipoVehiculo.Descripcion,
                Marca = v.Marca.Descripcion,
                Modelo = v.Modelo.Descripcion,
                TipoCombustible = v.TipoCombustible.Descripcion
            }).ToListAsync();
        }

        public void Update(Vehiculo vehiculo)
        {
            var vehiculoUpdate = Get(vehiculo.Id);
            vehiculoUpdate.Descripcion  = vehiculo.Descripcion;
            vehiculoUpdate.NoChasis = vehiculo.NoChasis;
            vehiculoUpdate.NoMotor = vehiculo.NoMotor;
            vehiculoUpdate.NoPlaca = vehiculo.NoPlaca;
            vehiculoUpdate.IdModelo = vehiculo.IdModelo;
            vehiculoUpdate.IdMarca = vehiculo.IdMarca;
            vehiculoUpdate.IdTipoCombustible = vehiculo.IdTipoCombustible;
            vehiculoUpdate.IdTipoVehiculo =  vehiculo.IdTipoVehiculo;
            vehiculoUpdate.Estado = vehiculo.Estado;
            vehiculoUpdate.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);

        }
    }
}
