using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;

namespace rencart.Repositories.Repository
{
    public class InspeccionRepository : BaseRepository<Inspeccion>, IInspeccionRepository
    {
        public RencarDbContext _context { get { return context; } }
        public InspeccionRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(Inspeccion inspeccion)
        {
            throw new System.NotImplementedException();
        }
    }
}
