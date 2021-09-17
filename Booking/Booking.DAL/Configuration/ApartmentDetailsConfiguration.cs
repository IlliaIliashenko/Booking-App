using Booking.DAL.Models.Booking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.DAL.Configuration
{
    public class ApartmentDetailsConfiguration : IEntityTypeConfiguration<ApartmentDetailsEntity>
    {
        public void Configure(EntityTypeBuilder<ApartmentDetailsEntity> builder)
        {
            builder.HasData(new ApartmentDetailsEntity()
            {
                Id = 1,
                ApartmentId = 1,
                Address = "Цілиноградська вулиця, 48-в, Харків, Харківська область, 61202",
                Floor = 2,
                Rooms = 2,
                Size = 87
            });
        }
    }
}