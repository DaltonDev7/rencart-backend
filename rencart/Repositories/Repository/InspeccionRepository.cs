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
    public class InspeccionRepository : BaseRepository<Inspeccion>, IInspeccionRepository
    {
        public RencarDbContext _context { get { return context; } }
        public InspeccionRepository(RencarDbContext context) : base(context)
        {
        }


        public async Task<dynamic> getAllInspecciones()
        {
            return await _context.Inspeccion.Select(i => new
            {
                i.Id,
                Vehiculo = i.Vehiculo.Descripcion,
                Cliente = i.Cliente.Nombres,
                i.CantidadCombustible,
                i.Fecha
            }).ToListAsync();
        }

        public void Update(Inspeccion inspeccion)
        {
            var updateInspeccion = Get(inspeccion.Id);
            updateInspeccion.TieneRayadura = inspeccion.TieneRayadura;
            updateInspeccion.CantidadCombustible = inspeccion.CantidadCombustible;
            updateInspeccion.TieneGomaRepuesto = inspeccion.TieneGomaRepuesto;
            updateInspeccion.TieneGato = inspeccion.TieneGato;
            updateInspeccion.TieneRoturaCristal = inspeccion.TieneRoturaCristal;
            updateInspeccion.Fecha = inspeccion.Fecha;
            updateInspeccion.IdCliente= inspeccion.IdCliente;
            updateInspeccion.IdEmpleado= inspeccion.IdEmpleado;
            updateInspeccion.IdVehiculo= inspeccion.IdVehiculo;
            updateInspeccion.FechaModificacion =  DateTime.UtcNow.AddMinutes(-240);
            //updateInspeccion.LlantaA = inspeccion.LlantaA;
            //updateInspeccion.LlantaB = inspeccion.LlantaB;
            //updateInspeccion.LlantaC = inspeccion.LlantaC;
            //updateInspeccion.LlantaD = inspeccion.LlantaD;
        }
    }
}
