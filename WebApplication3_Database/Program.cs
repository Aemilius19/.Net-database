using Microsoft.EntityFrameworkCore;
using WebApplication3_Database.DAL;

namespace WebApplication3_Database
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            builder.Services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseSqlServer(builder.Configuration.GetConnectionString("Mssql"));
            }
           );
            var app = builder.Build();
                     
            app.MapControllerRoute
                (
                name: "default",
                pattern: "{controller=home}/{action=index}"
                );
            app.UseStaticFiles();
            

            app.Run();
        }
    }
}
