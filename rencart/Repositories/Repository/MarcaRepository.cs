using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;
using System;

namespace rencart.Repositories.Repository
{
    public class MarcaRepository : BaseRepository<Marca>, IMarcaRepository
    {

        public RencarDbContext _context { get { return context; } }
        public MarcaRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(Marca marca)
        {
            var updateMarca = Get(marca.Id);
            updateMarca.Descripcion = marca.Descripcion;
            updateMarca.Estado = marca.Estado;
            updateMarca.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);
        }
    }
}
