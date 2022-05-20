using System.Collections.Generic;

namespace rencart.Entities
{
    public class TipoCombustible : EntityBase
    {
        public string Descripcion { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }

    }
}
