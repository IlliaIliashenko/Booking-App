using Booking.DAL.Models.Booking;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Booking.DAL.Configuration
{
    public class ApartmentPhotoConfiguration : IEntityTypeConfiguration<ApartmentPhotoEntity>
    {
        public void Configure(EntityTypeBuilder<ApartmentPhotoEntity> builder)
        {
            builder.HasData(
                new ApartmentPhotoEntity()
                {
                    Id = 1,
                    ApartmentId = 1,
                    Path = "ApartmentPhotos/apartment11.jpg"
                }, new ApartmentPhotoEntity()
                {
                    Id = 2,
                    ApartmentId = 1,
                    Path = "ApartmentPhotos/apartment12.jpg"
                }, 
                new ApartmentPhotoEntity()
                {
                    Id = 3,
                    ApartmentId = 1,
                    Path = "ApartmentPhotos/apartment13.jpg"
                }
                );
        }
    }
}