using Microsoft.EntityFrameworkCore;

namespace WebAPIProject.Models
{
    public class SDDBContext:DbContext
    {
        public SDDBContext(DbContextOptions<SDDBContext> options)
        {
            
        }
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=WebAPIProjectDB;Integrated Security=True;TrustServerCertificate=True;");
        }
    }
}
