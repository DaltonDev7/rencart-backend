namespace rencart.Entities
{
    public class Inspeccion : EntityBase
    {
        public bool TieneRayadura { get; set; }
        public string CantidadCombustible { get; set; }
        public bool TieneGomaRepuesto { get; set; }
        public bool TieneGato { get; set; }
        public bool TieneRoturaCristal { get; set; }

        public int IdVehiculo { get; set; }
        public int IdCliente { get; set; }
        public Vehiculo Vehiculo { get; set; }
        public Cliente Cliente { get; set; }


    }
}
