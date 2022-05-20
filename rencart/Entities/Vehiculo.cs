﻿namespace rencart.Entities
{
    public class Vehiculo : EntityBase
    {
        public string Descripcion { get; set; }
        public string NoChasis { get; set; }
        public string NoMotor { get; set; }
        public string NoPlaca { get; set; }

        public int IdTipoVehiculo { get; set; }

        public TipoVehiculo TipoVehiculo { get; set; }

    }
}
