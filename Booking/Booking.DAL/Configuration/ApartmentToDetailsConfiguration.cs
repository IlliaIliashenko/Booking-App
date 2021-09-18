using Booking.DAL.Models.Booking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.DAL.Configuration
{
    public class ApartmentToDetailsConfiguration : IEntityTypeConfiguration<DetailsToApartmentEntity>
    {
        public void Configure(EntityTypeBuilder<DetailsToApartmentEntity> builder)
        {
            builder.HasData(
                new DetailsToApartmentEntity()
                {
                    Id = 1,
                    ApartmentEntityId = 1,
                    DetailsEntityId = 1,
                    Value = "Цілиноградська вулиця, 48-в, Харків, Харківська область, 61202"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 2,
                    ApartmentEntityId = 1,
                    DetailsEntityId = 2,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 3,
                    ApartmentEntityId = 1,
                    DetailsEntityId = 3,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 4,
                    ApartmentEntityId = 1,
                    DetailsEntityId = 4,
                    Value = "87"
                });
        }
    }
}