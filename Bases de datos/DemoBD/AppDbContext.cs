using Microsoft.EntityFrameworkCore;

namespace DemoBD
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<Libro> Libros { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Configura el nombre de la base de datos acá
            optionsBuilder.UseSqlite("Data Source=BaseDatos.db");
        }
    }
}
