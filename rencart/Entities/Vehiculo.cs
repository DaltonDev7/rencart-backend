using System.Collections.Generic;

namespace rencart.Entities
{
    public class Vehiculo : EntityBase
    {
        public string Descripcion { get; set; }
        public string NoChasis { get; set; }
        public string NoMotor { get; set; }
        public string NoPlaca { get; set; }

        public int IdTipoVehiculo { get; set; }
        public int IdTipoCombustible { get; set; }
        public int IdModelo { get; set; }
        public int? IdMarca { get; set; }

        public TipoVehiculo TipoVehiculo { get; set; }
        public TipoCombustible TipoCombustible { get; set; }
        public Modelo Modelo { get; set; }
        public Marca Marca { get; set; }

        public ICollection<Inspeccion> Inspecciones { get; set; }
        public ICollection<RentaDevolucion> RentaDevolucion { get; set; }

    }
}
