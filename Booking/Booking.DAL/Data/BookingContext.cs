using Booking.DAL.Configuration;
using Booking.DAL.Models.Authentication;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Booking.DAL.Data
{
    public class BookingContext : IdentityDbContext<UserEntity, RoleEntity, int>
    {
        public BookingContext(DbContextOptions<BookingContext> options):
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleEntityConfiguration());
            modelBuilder.ApplyConfiguration(new RoleClaimsConfiguration());
        }
    }
}