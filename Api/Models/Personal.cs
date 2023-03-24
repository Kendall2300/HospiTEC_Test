namespace API_Tareadef.Models
{
    public class Personal
    {
        public string Nombre { get; set; } = string.Empty;
        public string Apellido1 { get; set; } = string.Empty;
        public string Apellido2 { get; set; } = string.Empty;
        public int Cedula { get; set; } = 0;
        public string Fecha_Nacimiento { get; set; } = string.Empty;
        public string Contrasena { get; set; } = string.Empty;
        public string Fecha_Ingreso { get; set; } = string.Empty;
        public int ID_Profesion { get; set; } = 0;
    }
}
