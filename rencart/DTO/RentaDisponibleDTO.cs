using System;

namespace rencart.DTO
{
    public class RentaDisponibleDTO
    {
        public int? Id { get; set; }
        public int IdVehiculo { get; set; }
        public DateTime FechaRenta { get; set; }
        public DateTime FechaDevolucion { get; set; }
    }
}
