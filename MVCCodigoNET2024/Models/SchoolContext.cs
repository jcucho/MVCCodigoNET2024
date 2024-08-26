using Microsoft.EntityFrameworkCore;
using MVCCodigoNET2024.Models;

namespace MVCCodigoNET2024.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options): base(options)
        {
                
        }

        
    }
}
