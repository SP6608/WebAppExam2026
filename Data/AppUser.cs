using Microsoft.AspNetCore.Identity;

namespace WebAppAdvance.Data
{
    public class AppUser:IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
