using Microsoft.EntityFrameworkCore;

namespace MVCCodigoNET2024.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        public SchoolContext(DbContextOptions<SchoolContext> options): base(options)
        {
                
        }
    }
}
