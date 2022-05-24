using rencart.Context;
using rencart.Entities;
using rencart.Interfaces;
using rencart.Repositories.Generico;
using System;

namespace rencart.Repositories.Repository
{
    public class TipoPersonaRepository : BaseRepository<TipoPersona>, ITipoPersonaRepository
    {
        public TipoPersonaRepository(RencarDbContext context) : base(context)
        {
        }

        public void Update(TipoPersona tipoPersona)
        {
            var tipoPersonaUpdate = Get(tipoPersona.Id);
            tipoPersonaUpdate.Descripcion = tipoPersona.Descripcion;
            tipoPersonaUpdate.Estado = tipoPersona.Estado;
            tipoPersonaUpdate.FechaModificacion =  DateTime.UtcNow.AddMinutes(-240);
        }
    }
}
