namespace GestionProyectos.Models
{
    public class Proyecto
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Cliente { get; set; } = string.Empty;
        public string Responsable { get; set; } = string.Empty;
        public string Estado { get; set; } = "en-curso"; // en-curso, en-riesgo, completado
        public int Progreso { get; set; } = 0;
        public DateTime FechaEntrega { get; set; }
        public DateTime FechaCreacion { get; set; } = DateTime.Now;

        // Relación con tareas y comentarios
        public List<Tarea> Tareas { get; set; } = new();
        public List<Comentario> Comentarios { get; set; } = new();
    }
}