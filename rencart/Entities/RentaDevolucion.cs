using System;

namespace rencart.Entities
{
    public class RentaDevolucion : EntityBase
    {
        public DateTime FechaRenta { get; set; }
        public DateTime FechaDevolucion { get; set; }
        public int MontoPorDia { get; set; }
        public int CantidadPorDia { get; set; }
        public string Comentario { get; set; }
    }
}
