using EscuelaAPI.Models;
using Microsoft.EntityFrameworkCore;
 
namespace EscuelaAPI.Data
{
    public class EscuelaContext(DbContextOptions<EscuelaContext> options) : DbContext(options)
    {
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>().HasKey(c => c.IdCurso);
            modelBuilder.Entity<Estudiante>().HasKey(e => e.IdEstudiante);
            modelBuilder.Entity<Usuario>().HasKey(u => u.IdUsuario);
        }
    }
   
}