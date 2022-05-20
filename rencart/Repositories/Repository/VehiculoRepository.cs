using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;

namespace rencart.Repositories.Repository
{
    public class VehiculoRepository : BaseRepository<Vehiculo>, IVehiculoRepository
    {
        public VehiculoRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(Vehiculo vehiculo)
        {
            throw new System.NotImplementedException();
        }
    }
}
