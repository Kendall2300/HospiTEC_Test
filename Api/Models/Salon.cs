namespace API_Tareadef.Models
{
    public class Salon
    {
        public int Salon_Numero { get; set; } = 0;
        public string Nombre_Salon { get; set; } = string.Empty;
        public int Capacidad { get; set; } = 0;
        public string Piso { get; set; } = string.Empty;
        public int Camas_Disponibles { get; set; } = 0;
        public int ID_Tipo_Salon { get; set; } = 0;
    }
}
