using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.DAL.Configuration
{
    public class RoleClaimsConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<int>>
    {
        public void Configure(EntityTypeBuilder<IdentityRoleClaim<int>> builder)
        {
            builder.HasData(new IdentityRoleClaim<int>()
            {
                Id = 1,
                RoleId = 1,
                ClaimType = "Booking.Permission",
                ClaimValue = "users.view"
            });
        }
    }
}