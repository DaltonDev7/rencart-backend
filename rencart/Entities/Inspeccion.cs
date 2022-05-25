using System;

namespace rencart.Entities
{
    public class Inspeccion : EntityBase
    {
        public bool TieneRayadura { get; set; }
        public string CantidadCombustible { get; set; }
        public bool TieneGomaRepuesto { get; set; }
        public bool TieneGato { get; set; }
        public bool TieneRoturaCristal { get; set; }
        public bool LlantaA{ get; set; }
        public bool LlantaB { get; set; }
        public bool LlantaC { get; set; }
        public bool LlantaD { get; set; }
        public DateTime Fecha { get; set; }

        public int IdVehiculo { get; set; }
        public int IdCliente { get; set; }
        public int IdEmpleado { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }


    }
}
