using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppAdvance.Models;

namespace WebAppAdvance.Data
{
    public class ApplicationDbContext:IdentityDbContext<AppUser,AppRole,string>
        
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
        :base(options) { }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
        }
        public virtual DbSet<Car> Cars { get; set; } = null!;
    }
}
