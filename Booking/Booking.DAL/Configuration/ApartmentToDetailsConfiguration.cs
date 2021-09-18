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
                },
                new DetailsToApartmentEntity()
                {
                    Id = 5,
                    ApartmentEntityId = 2,
                    DetailsEntityId = 1,
                    Value = "Сумська вулиця, 18-а, Харків, Харківська область, 61106"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 6,
                    ApartmentEntityId = 2,
                    DetailsEntityId = 2,
                    Value = "3"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 7,
                    ApartmentEntityId = 2,
                    DetailsEntityId = 3,
                    Value = "3"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 8,
                    ApartmentEntityId = 2,
                    DetailsEntityId = 4,
                    Value = "105"
                });
        }
    }
}