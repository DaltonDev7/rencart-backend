using System.Collections.Generic;

namespace rencart.Entities
{
    public class Modelo : EntityBase
    {
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }

        public Marca Marca { get; set; }

        public ICollection<Vehiculo> Vehiculos { get; set; }

    }
}
