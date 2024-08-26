using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Data
{
    public class AppDbContex : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContex(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        public DbSet<User> Users { get; set; }

    }   
}

