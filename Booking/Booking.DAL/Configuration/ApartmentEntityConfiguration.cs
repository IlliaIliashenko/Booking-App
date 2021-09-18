using Booking.DAL.Models.Booking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.DAL.Configuration
{
    public class ApartmentEntityConfiguration : IEntityTypeConfiguration<ApartmentEntity>
    {
        public void Configure(EntityTypeBuilder<ApartmentEntity> builder)
        {
            builder.HasData(
                new ApartmentEntity()
                {
                    Id = 1,
                    Name = "Аренда VIP 2-ух комнатной квартиры в Новострое",
                    Price = 9500
                },
                new ApartmentEntity()
                {
                    Id = 2,
                    Name = "Аренда 3-x комнатной квартиры в центре",
                    Price = 15500
                });
        }
    }
}