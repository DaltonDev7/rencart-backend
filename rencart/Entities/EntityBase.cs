using System;

namespace rencart.Entities
{
    public class EntityBase
    {
        public int Id { get; set; }
        public int? Estado { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime? FechaModificacion { get; set; }
    }
}
