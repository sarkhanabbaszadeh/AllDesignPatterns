using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Strategy.Models;

namespace BaseProject.Models
{
    public class AppIdentityDBContext : IdentityDbContext<AppUser>
    {
        public AppIdentityDBContext(DbContextOptions<AppIdentityDBContext> options) : base(options)
        {
            
        }

        public DbSet<Product> Products { get; set; } //For EFCore
    }
}
