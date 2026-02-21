using GestionProyectos.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace GestionProyectos.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Proyecto> Proyectos { get; set; }
        public DbSet<Tarea> Tareas { get; set; }
        public DbSet<Comentario> Comentarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Proyecto
            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Nombre).IsRequired().HasMaxLength(200);
                entity.Property(p => p.Cliente).IsRequired().HasMaxLength(200);
                entity.Property(p => p.Responsable).IsRequired().HasMaxLength(100);
                entity.Property(p => p.Estado).HasMaxLength(20);
            });

            // Tarea — pertenece a un Proyecto
            modelBuilder.Entity<Tarea>(entity =>
            {
                entity.HasKey(t => t.Id);
                entity.Property(t => t.Texto).IsRequired().HasMaxLength(300);
                entity.HasOne(t => t.Proyecto)
                      .WithMany(p => p.Tareas)
                      .HasForeignKey(t => t.ProyectoId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Comentario — pertenece a un Proyecto
            modelBuilder.Entity<Comentario>(entity =>
            {
                entity.HasKey(c => c.Id);
                entity.Property(c => c.Autor).IsRequired().HasMaxLength(100);
                entity.Property(c => c.Texto).IsRequired().HasMaxLength(1000);
                entity.HasOne(c => c.Proyecto)
                      .WithMany(p => p.Comentarios)
                      .HasForeignKey(c => c.ProyectoId)
                      .OnDelete(DeleteBehavior.Cascade);
            });

            // Datos iniciales de ejemplo
            modelBuilder.Entity<Proyecto>().HasData(
                new Proyecto
                {
                    Id = 1,
                    Nombre = "Transformación Digital — BancoNorte",
                    Cliente = "BancoNorte S.A.",
                    Responsable = "Valentina Cruz",
                    Estado = "en-curso",
                    Progreso = 68,
                    FechaEntrega = new DateTime(2026, 3, 15),
                    FechaCreacion = new DateTime(2026, 1, 1)
                },
                new Proyecto
                {
                    Id = 2,
                    Nombre = "Optimización Supply Chain — RetailMax",
                    Cliente = "RetailMax Corp.",
                    Responsable = "Diego Morales",
                    Estado = "en-riesgo",
                    Progreso = 42,
                    FechaEntrega = new DateTime(2026, 2, 28),
                    FechaCreacion = new DateTime(2026, 1, 1)
                },
                new Proyecto
                {
                    Id = 3,
                    Nombre = "Estrategia ESG — GrupoVerde",
                    Cliente = "GrupoVerde Holding",
                    Responsable = "Sofía Leal",
                    Estado = "completado",
                    Progreso = 100,
                    FechaEntrega = new DateTime(2026, 1, 31),
                    FechaCreacion = new DateTime(2026, 1, 1)
                }
            );
        }
    }
}