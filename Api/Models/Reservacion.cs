namespace API_Tareadef.Models
{
    public class Reservacion
    {
        public int ID_Reservacion { get; set; } = 0;
        public string Fecha_Ingreso { get; set; } = string.Empty;
        public int Dias_Requeridos { get; set; } = 0;
        public int Fecha_Sal { get; set; } = 0;
        public Procedimiento_Medico PM { get; set; } = new Procedimiento_Medico();

    }
}
