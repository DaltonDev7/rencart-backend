using System.Collections;
using System.Collections.Generic;

namespace rencart.Entities
{
    public class Marca : EntityBase
    {
        public string Descripcion { get; set; }

        public ICollection<Modelo> Modelos { get; set; }
    }
}
