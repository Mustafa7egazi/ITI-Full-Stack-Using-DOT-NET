using Microsoft.EntityFrameworkCore;

namespace MvcCourseProject.Models.DBModels
{
    public class LearnContext : DbContext
    {

        public LearnContext(DbContextOptions<LearnContext> options):base(options)
        {
            
        }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }

        public virtual DbSet<Trainee> Trainees { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

        public virtual DbSet<CrsResult> CrsResults { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=LearnMvcDb;Trusted_Connection=True; Trust Server Certificate = True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Department → Instructors (one-to-many)
            modelBuilder.Entity<Instructor>()
                .HasOne(i => i.Department)
                .WithMany(d => d.Instructors)
                .HasForeignKey(i => i.DepartmentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Department → Manager (one-to-one self-reference)
            modelBuilder.Entity<Department>()
                .HasOne(d => d.Manager)
                .WithMany()
                .HasForeignKey(d => d.ManagerId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }

}

