using Microsoft.AspNetCore.Identity;

namespace WebAppAdvance.Data
{
    public class AppRole:IdentityRole
    {
        public DateTime OnCreate { get; set; }= DateTime.Now;
    }
}
