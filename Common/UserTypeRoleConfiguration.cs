using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebAppAdvance.Data;

namespace WebAppAdvance.Common
{
    public class UserTypeRoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        private static readonly ICollection<AppRole> Roles= new HashSet<AppRole>()
        {
            new AppRole(){Id="66f4c9a2-aadc-44c3-9943-d09adc3522c4",Name="Administrator",NormalizedName="ADMINISTRATOR", ConcurrencyStamp = "11111111-1111-1111-1111-111111111111",
                    OnCreate = new DateTime(2026, 3, 22)},
            new AppRole(){Id="a8cd3219-0e9c-4456-9646-e9ec31f42ac9",Name="Employee",NormalizedName="EMPLOYEE", ConcurrencyStamp = "22222222-2222-2222-2222-222222222222",
                    OnCreate = new DateTime(2026, 3, 22)}
        };
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(Roles);
        }
    }
}
