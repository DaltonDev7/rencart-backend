using rencart.Entities;

namespace rencart.DTO
{
    public class UpdateRentaDTO
    {
        public RentaDevolucion rentaAntesPayload { get; set; }
        public RentaDevolucion rentaActualPayload { get; set; }
    }
}
