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
    public class ModeloRepository : BaseRepository<Modelo>, IModeloRepository
    {
        public RencarDbContext _context { get { return context; } }
        public ModeloRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(Modelo modelo)
        {
            var updateModelo = Get(modelo.Id);
            updateModelo.IdMarca = modelo.IdMarca;
            updateModelo.Descripcion = modelo.Descripcion;
            updateModelo.Estado = modelo.Estado;
            updateModelo.FechaModificacion = DateTime.UtcNow.AddMinutes(-240);

        }

        public async Task<dynamic> getModeloById(int idModelo)
        {
            return await _context.Modelo.Select(m => new
            {
                m.Id,
                m.Descripcion,
                m.Estado,
                MarcaDescripcion = m.Marca.Descripcion
            }).Where(m => m.Id == idModelo).ToListAsync();
        }


        public async Task<dynamic> getModelos()
        {
            return  await _context.Modelo.Select(m => new
            {
                m.Id,
                m.Descripcion,
                m.Estado,
                MarcaDescripcion = m.Marca.Descripcion
            }).ToListAsync();
        }

    }
}
