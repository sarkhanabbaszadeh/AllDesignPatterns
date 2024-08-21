using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BaseProject.Models
{
    public class AppIdentityDBContext : IdentityDbContext
    {
        public AppIdentityDBContext(DbContextOptions<AppIdentityDBContext> options) : base(options)
        {
            
        }
    }
}
