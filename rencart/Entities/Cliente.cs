namespace rencart.Entities
{
    public class Cliente : EntityBase
    {

        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public string Cedula { get; set; }

        public string NoTarjetaCR { get; set; }
        public int LimiteCredito { get; set; }
        public int IdTipoPersona { get; set; }
        public TipoPersona TipoPersona { get; set; }
    }
}
