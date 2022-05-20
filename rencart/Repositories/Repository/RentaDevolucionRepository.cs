using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;

namespace rencart.Repositories.Repository
{
    public class RentaDevolucionRepository : BaseRepository<RentaDevolucion>, IRentaDevolucionRepository
    {
        public RentaDevolucionRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(RentaDevolucion entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
