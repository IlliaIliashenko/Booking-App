using System.Collections.Generic;
using Booking.DAL.Models.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.DAL.Configuration
{
    public class RoleEntityConfiguration : IEntityTypeConfiguration<RoleEntity>
    {
        public void Configure(EntityTypeBuilder<RoleEntity> builder)
        {
            builder.HasData(new RoleEntity()
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = 1
                },
                new RoleEntity()
                {
                    Name = "UserWithNoPermission",
                    NormalizedName = "USERWITHNOPERMISSION",
                    Id = 2
                }
                );
        }
    }
}