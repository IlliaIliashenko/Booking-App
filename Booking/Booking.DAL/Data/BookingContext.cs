using Booking.DAL.Configuration;
using Booking.DAL.Models.Authentication;
using Booking.DAL.Models.Booking;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Booking.DAL.Data
{
    public class BookingContext : IdentityDbContext<UserEntity, RoleEntity, int>
    {
        public DbSet<ApartmentEntity> Apartments { get; set; }
        public DbSet<ApartmentPhotoEntity> ApartmentPhotos { get; set; }
        public DbSet<ApartmentDetailsEntity> ApartmentDetails { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }

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