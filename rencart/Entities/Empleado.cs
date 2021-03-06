using System;
using System.Collections.Generic;

namespace rencart.Entities
{
    public class Empleado : EntityBase
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }
        public string TandaLabor { get; set; }
        public int PorcientoComision { get; set; }
        public DateTime FechaIngreso { get; set; }
        public ICollection<Inspeccion> Inspecciones { get; set; }
        public ICollection<RentaDevolucion> RentaDevolucion { get; set; }

    }
}
