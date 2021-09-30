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
                    ApartmentId = 1,
                    DetailsId = 1,
                    Value = "Цілиноградська вулиця, 48-в, Харків, Харківська область, 61202"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 2,
                    ApartmentId = 1,
                    DetailsId = 2,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 3,
                    ApartmentId = 1,
                    DetailsId = 3,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 4,
                    ApartmentId = 1,
                    DetailsId = 4,
                    Value = "87"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 5,
                    ApartmentId = 2,
                    DetailsId = 1,
                    Value = "Новые дома 25 микрорайон"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 6,
                    ApartmentId = 2,
                    DetailsId = 2,
                    Value = "3"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 7,
                    ApartmentId = 2,
                    DetailsId = 3,
                    Value = "3"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 8,
                    ApartmentId = 2,
                    DetailsId = 4,
                    Value = "45"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 9,
                    ApartmentId = 3,
                    DetailsId = 1,
                    Value = "м.Университет"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 10,
                    ApartmentId = 3,
                    DetailsId = 2,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 11,
                    ApartmentId = 3,
                    DetailsId = 3,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 12,
                    ApartmentId = 3,
                    DetailsId = 4,
                    Value = "71"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 13,
                    ApartmentId = 4,
                    DetailsId = 1,
                    Value = "ул.Сумская,Новострой"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 14,
                    ApartmentId = 4,
                    DetailsId = 2,
                    Value = "10"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 15,
                    ApartmentId = 4,
                    DetailsId = 3,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 16,
                    ApartmentId = 4,
                    DetailsId = 4,
                    Value = "95"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 17,
                    ApartmentId = 5,
                    DetailsId = 1,
                    Value = "улица Дидро 30,метро Академика Павлова"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 18,
                    ApartmentId = 5,
                    DetailsId = 2,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 19,
                    ApartmentId = 5,
                    DetailsId = 3,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 20,
                    ApartmentId = 5,
                    DetailsId = 4,
                    Value = "18"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 21,
                    ApartmentId = 6,
                    DetailsId = 1,
                    Value = "ЖК Ньютона, м,Дворец спорта"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 22,
                    ApartmentId = 6,
                    DetailsId = 2,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 23,
                    ApartmentId = 6,
                    DetailsId = 3,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 24,
                    ApartmentId = 6,
                    DetailsId = 4,
                    Value = "37"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 25,
                    ApartmentId = 7,
                    DetailsId = 1,
                    Value = "ЖК Квартет возле ТРК Украина"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 26,
                    ApartmentId = 7,
                    DetailsId = 2,
                    Value = "10"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 27,
                    ApartmentId = 7,
                    DetailsId = 3,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 28,
                    ApartmentId = 7,
                    DetailsId = 4,
                    Value = "42"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 29,
                    ApartmentId = 8,
                    DetailsId = 1,
                    Value = "проспект Л. Свободы."
                },
                new DetailsToApartmentEntity()
                {
                    Id = 30,
                    ApartmentId = 8,
                    DetailsId = 2,
                    Value = "9"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 31,
                    ApartmentId = 8,
                    DetailsId = 3,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 32,
                    ApartmentId = 8,
                    DetailsId = 4,
                    Value = "34"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 33,
                    ApartmentId = 9,
                    DetailsId = 1,
                    Value = "Новые Дома"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 34,
                    ApartmentId = 9,
                    DetailsId = 2,
                    Value = "3"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 35,
                    ApartmentId = 9,
                    DetailsId = 3,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 36,
                    ApartmentId = 9,
                    DetailsId = 4,
                    Value = "35"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 37,
                    ApartmentId = 10,
                    DetailsId = 1,
                    Value = "Центр м. Исторический музей"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 38,
                    ApartmentId = 10,
                    DetailsId = 2,
                    Value = "3"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 39,
                    ApartmentId = 10,
                    DetailsId = 3,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 40,
                    ApartmentId = 10,
                    DetailsId = 4,
                    Value = "40"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 41,
                    ApartmentId = 11,
                    DetailsId = 1,
                    Value = "Московский район"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 42,
                    ApartmentId = 11,
                    DetailsId = 2,
                    Value = "10"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 43,
                    ApartmentId = 11,
                    DetailsId = 3,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 44,
                    ApartmentId = 11,
                    DetailsId = 4,
                    Value = "42"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 45,
                    ApartmentId = 12,
                    DetailsId = 1,
                    Value = "Победа(Алексеевка)"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 46,
                    ApartmentId = 12,
                    DetailsId = 2,
                    Value = "7"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 47,
                    ApartmentId = 12,
                    DetailsId = 3,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 48,
                    ApartmentId = 12,
                    DetailsId = 4,
                    Value = "38"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 49,
                    ApartmentId = 13,
                    DetailsId = 1,
                    Value = "в новострое Салтовка МЖК метро ГероевТруда"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 50,
                    ApartmentId = 13,
                    DetailsId = 2,
                    Value = "7"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 51,
                    ApartmentId = 13,
                    DetailsId = 3,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 52,
                    ApartmentId = 13,
                    DetailsId = 4,
                    Value = "57"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 53,
                    ApartmentId = 14,
                    DetailsId = 1,
                    Value = "ул Бучмы, метро Героев Труда"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 54,
                    ApartmentId = 14,
                    DetailsId = 2,
                    Value = "5"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 55,
                    ApartmentId = 14,
                    DetailsId = 3,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 56,
                    ApartmentId = 14,
                    DetailsId = 4,
                    Value = "38"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 57,
                    ApartmentId = 15,
                    DetailsId = 1,
                    Value = "воробьевы горы"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 58,
                    ApartmentId = 15,
                    DetailsId = 2,
                    Value = "1"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 59,
                    ApartmentId = 15,
                    DetailsId = 3,
                    Value = "12"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 60,
                    ApartmentId = 15,
                    DetailsId = 4,
                    Value = "19"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 61,
                    ApartmentId = 16,
                    DetailsId = 1,
                    Value = "Цілиноградська вулиця, 48-в, Харків, Харківська область, 61202"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 62,
                    ApartmentId = 16,
                    DetailsId = 2,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 63,
                    ApartmentId = 16,
                    DetailsId = 3,
                    Value = "2"
                },
                new DetailsToApartmentEntity()
                {
                    Id = 64,
                    ApartmentId = 16,
                    DetailsId = 4,
                    Value = "87"
                });
        }
    }
}