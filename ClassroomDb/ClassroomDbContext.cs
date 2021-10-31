using Microsoft.EntityFrameworkCore;

namespace ClassroomDb
{
    public class ClassroomDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
            @"Server=.\SQLEXPRESS;Database=ClassroomDb;Integrated Security=SSPI;");
        }
    }
}
