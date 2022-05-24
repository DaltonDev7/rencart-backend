using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;
using System;

namespace rencart.Repositories.Repository
{
    public class EmpleadoRepository : BaseRepository<Empleado>, IEmpleadoRepository
    {
        public RencarDbContext _context { get { return context; } }
        public EmpleadoRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(Empleado empleado)
        {
            var updateEmpleado = Get(empleado.Id);
            updateEmpleado.Nombres = empleado.Nombres;
            updateEmpleado.Apellidos = empleado.Apellidos;
            updateEmpleado.Estado = empleado.Estado;
            updateEmpleado.FechaIngreso = empleado.FechaIngreso;
            updateEmpleado.Cedula = empleado.Cedula;    
            updateEmpleado.TandaLabor = empleado.TandaLabor;
            updateEmpleado.PorcientoComision = empleado.PorcientoComision;
            updateEmpleado.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);
        }
    }
}
