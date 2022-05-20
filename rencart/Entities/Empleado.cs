using System;

namespace rencart.Entities
{
    public class Empleado : EntityBase
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string TandaLabor { get; set; }
        public string PorcientoComision { get; set; }
        public DateTime FechaIngreso { get; set; }
    }
}
