using CrudUniversity.Models;
using Microsoft.EntityFrameworkCore;

namespace CrudUniversity.Data
{
    public class AplicationDbContext: DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options): base (options)
        {
            
        }
        public DbSet<Course>Courses { get; set; }
        public DbSet<Enrollment> Enrollments { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
