namespace GestionProyectos.Models
{
    public class Comentario
    {
        public int Id { get; set; }
        public string Autor { get; set; } = string.Empty;
        public string Texto { get; set; } = String.Empty;
        public DateTime Fecha { get; set; } = DateTime.Now;

        // Relación con proyecto
        public int ProyectoId { get; set; }
        public Proyecto? Proyecto { get; set; }
    }
}
