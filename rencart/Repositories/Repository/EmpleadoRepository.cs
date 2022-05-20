using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;

namespace rencart.Repositories.Repository
{
    public class EmpleadoRepository : BaseRepository<Empleado>, IEmpleadoRepository
    {
        public EmpleadoRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(Empleado empleado)
        {
            throw new System.NotImplementedException();
        }
    }
}
