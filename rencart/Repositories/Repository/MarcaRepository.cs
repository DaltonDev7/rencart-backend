using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;

namespace rencart.Repositories.Repository
{
    public class MarcaRepository : BaseRepository<Marca>, IMarcaRepository
    {

        public RencarDbContext _context { get { return context; } }
        public MarcaRepository(RencarDbContext context) : base(context)
        {
        }


    }
}
