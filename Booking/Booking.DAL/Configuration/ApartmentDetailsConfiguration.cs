using System;
using Booking.DAL.Models.Booking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.DAL.Configuration
{
    public class ApartmentDetailsConfiguration : IEntityTypeConfiguration<DetailsEntity>
    {
        public void Configure(EntityTypeBuilder<DetailsEntity> builder)
        {
            builder.HasData(
                new DetailsEntity()
                {
                    Id = 1,
                    Name = "Address",
                    ValueType = "System.String"
                },
                new DetailsEntity()
                {
                    Id = 2,
                    Name = "Floor",
                    ValueType = "System.Int32"
                },
                new DetailsEntity()
                {
                    Id = 3,
                    Name = "Rooms",
                    ValueType = "System.Int32"
                },
                new DetailsEntity()
                {
                    Id = 4,
                    Name = "Size",
                    ValueType = "System.Int32"
                });
        }
    }
}