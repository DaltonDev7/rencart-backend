using rencart.Entities;

namespace rencart.Interfaces
{
    public interface ITipoPersonaRepository : IBaseRepository<TipoPersona>
    {
        void Update(TipoPersona tipoPersona);
    }
}
