using rencart.Entities;

namespace rencart.Interfaces
{
    public interface IEmpleadoRepository : IBaseRepository<Empleado>
    {
        void Update(Empleado empleado);
    }
}
