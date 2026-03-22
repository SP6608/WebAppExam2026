using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebAppAdvance.Data
{
    public class ApplicationDbContext:IdentityDbContext<AppUser,AppRole,string>
        
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
        :base(options) { }
            
        
    }
}
