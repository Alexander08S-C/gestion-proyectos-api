namespace GestionProyectos.Models
{
    public class Tarea
    {
        public int Id { get; set; }
        public String Texto { get; set; } = String.Empty;
        public bool Hecha { get; set; } = false;
        public DateTime FechaCreacion { get; set; } = DateTime.Now;
        // Relación con proyecto
        public int ProyectoId { get; set; }
        public Proyecto? Proyecto { get; set; }
    }
}
