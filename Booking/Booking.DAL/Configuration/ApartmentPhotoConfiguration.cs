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
                }, 
                new ApartmentPhotoEntity()
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
                },
                new ApartmentPhotoEntity()
                {
                    Id = 4,
                    ApartmentId = 2,
                    Path = "ApartmentPhotos/apartment21.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 5,
                    ApartmentId = 2,
                    Path = "ApartmentPhotos/apartment22.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 6,
                    ApartmentId = 2,
                    Path = "ApartmentPhotos/apartment23.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 7,
                    ApartmentId = 3,
                    Path = "ApartmentPhotos/apartment31.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 8,
                    ApartmentId = 3,
                    Path = "ApartmentPhotos/apartment32.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 9,
                    ApartmentId = 3,
                    Path = "ApartmentPhotos/apartment33.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 10,
                    ApartmentId = 4,
                    Path = "ApartmentPhotos/apartment41.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 11,
                    ApartmentId = 4,
                    Path = "ApartmentPhotos/apartment42.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 12,
                    ApartmentId = 4,
                    Path = "ApartmentPhotos/apartment43.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 13,
                    ApartmentId = 5,
                    Path = "ApartmentPhotos/apartment51.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 14,
                    ApartmentId = 5,
                    Path = "ApartmentPhotos/apartment52.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 15,
                    ApartmentId = 5,
                    Path = "ApartmentPhotos/apartment53.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 16,
                    ApartmentId = 6,
                    Path = "ApartmentPhotos/apartment61.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 17,
                    ApartmentId = 6,
                    Path = "ApartmentPhotos/apartment62.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 18,
                    ApartmentId = 6,
                    Path = "ApartmentPhotos/apartment63.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 19,
                    ApartmentId = 7,
                    Path = "ApartmentPhotos/apartment71.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 20,
                    ApartmentId = 7,
                    Path = "ApartmentPhotos/apartment72.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 21,
                    ApartmentId = 7,
                    Path = "ApartmentPhotos/apartment73.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 22,
                    ApartmentId = 8,
                    Path = "ApartmentPhotos/apartment81.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 23,
                    ApartmentId = 8,
                    Path = "ApartmentPhotos/apartment82.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 24,
                    ApartmentId = 8,
                    Path = "ApartmentPhotos/apartment83.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 25,
                    ApartmentId = 9,
                    Path = "ApartmentPhotos/apartment91.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 26,
                    ApartmentId = 9,
                    Path = "ApartmentPhotos/apartment92.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 27,
                    ApartmentId = 9,
                    Path = "ApartmentPhotos/apartment93.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 28,
                    ApartmentId = 10,
                    Path = "ApartmentPhotos/apartment101.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 29,
                    ApartmentId = 10,
                    Path = "ApartmentPhotos/apartment102.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 30,
                    ApartmentId = 10,
                    Path = "ApartmentPhotos/apartment103.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 31,
                    ApartmentId = 11,
                    Path = "ApartmentPhotos/apartment111.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 32,
                    ApartmentId = 11,
                    Path = "ApartmentPhotos/apartment112.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 33,
                    ApartmentId = 11,
                    Path = "ApartmentPhotos/apartment113.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 34,
                    ApartmentId = 12,
                    Path = "ApartmentPhotos/apartment121.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 35,
                    ApartmentId = 12,
                    Path = "ApartmentPhotos/apartment122.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 36,
                    ApartmentId = 12,
                    Path = "ApartmentPhotos/apartment123.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 37,
                    ApartmentId = 13,
                    Path = "ApartmentPhotos/apartment131.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 38,
                    ApartmentId = 13,
                    Path = "ApartmentPhotos/apartment132.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 39,
                    ApartmentId = 13,
                    Path = "ApartmentPhotos/apartment133.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 40,
                    ApartmentId = 14,
                    Path = "ApartmentPhotos/apartment141.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 41,
                    ApartmentId = 14,
                    Path = "ApartmentPhotos/apartment142.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 42,
                    ApartmentId = 14,
                    Path = "ApartmentPhotos/apartment143.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 43,
                    ApartmentId = 15,
                    Path = "ApartmentPhotos/apartment151.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 44,
                    ApartmentId = 15,
                    Path = "ApartmentPhotos/apartment152.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 45,
                    ApartmentId = 15,
                    Path = "ApartmentPhotos/apartment153.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 46,
                    ApartmentId = 16,
                    Path = "ApartmentPhotos/apartment161.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 47,
                    ApartmentId = 16,
                    Path = "ApartmentPhotos/apartment162.jpg"
                },
                new ApartmentPhotoEntity()
                {
                    Id = 48,
                    ApartmentId = 16,
                    Path = "ApartmentPhotos/apartment163.jpg"
                }


                );
        }
    }
}