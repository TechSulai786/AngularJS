using Microsoft.EntityFrameworkCore;

namespace apis.Models
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {

        }
        public DbSet<Students> Students {get; set;}
    }
}