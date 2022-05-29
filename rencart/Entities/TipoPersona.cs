using System.Collections.Generic;

namespace rencart.Entities
{
    public class TipoPersona : EntityBase
    {
        public string Descripcion { get; set; }
        public ICollection<Cliente> Clientes { get; set; }
    }
}
