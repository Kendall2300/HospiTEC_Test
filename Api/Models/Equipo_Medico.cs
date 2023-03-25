namespace API_Tareadef.Models
{
    public class Equipo_Medico
    {
        public int ID_Equipo_Medico { get; set; }
        public string Nombre_Equipo_Medico { get; set; }
        public int Cantidad_Disponible { get; set; }
        public string Proveedor { get; set; } 
        public int Numero_Cama { get; set; } 
    }
}
