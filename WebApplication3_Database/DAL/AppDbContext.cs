using Microsoft.EntityFrameworkCore;
using WebApplication3_Database.Models;

namespace WebApplication3_Database.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

            
        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Testimonial> Tests { get; set; }
    }
}
