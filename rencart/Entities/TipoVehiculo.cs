using System.Collections.Generic;

namespace rencart.Entities
{
    public class TipoVehiculo : EntityBase
    {
        public string Descripcion { get; set; }
        public ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
