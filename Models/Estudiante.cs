namespace EscuelaAPI.Models 
{
    public class Estudiante
    {
        public int IdEstudiante { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int IdCurso { get; set; }
        public string Direccion { get; set; }
    }
}