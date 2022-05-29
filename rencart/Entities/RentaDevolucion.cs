using System;

namespace rencart.Entities
{
    public class RentaDevolucion : EntityBase
    {
        public DateTime FechaRenta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int MontoPorDia { get; set; }
        public int CantidadPorDia { get; set; }
        public int CantidadDias { get; set; }
        public string Comentario { get; set; }
        public Boolean? confirmarDevolucion { get; set; }

        public int IdCliente { get; set; }
        public int IdVehiculo { get; set; }
        public int IdEmpleado { get; set; }

        public Empleado Empleado { get; set; }
        public Cliente Cliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
    }
}
