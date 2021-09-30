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
                    Name = "Сдам 2 к. кв Новые дома 25 микрорайон",
                    Price = 6500
                },
                new ApartmentEntity()
                {
                    Id = 3,
                    Name = "Сдам 2-х комнатную квартиру (71 м2), 5 минут от м. Университет",
                    Price = 15000
                },
                new ApartmentEntity()
                {
                    Id = 4,
                    Name = "Сдам 3-ком.квартиру на Сухумской",
                    Price = 27000
                },
                new ApartmentEntity()
                {
                    Id = 5,
                    Name = "Сдам гостинку",
                    Price = 3000
                },
                new ApartmentEntity()
                {
                    Id = 6,
                    Name = "Сдам 1к кв в ЖК Ньютона, м,Дворец спорта",
                    Price = 8000
                },
                new ApartmentEntity()
                {
                    Id = 7,
                    Name = "Сдам 1к квартиру новострой ЖК Квартет возле ТРК Украина",
                    Price = 7300
                },
                new ApartmentEntity()
                {
                    Id = 8,
                    Name = "Сдам 1-к квартиру, рядом метро Алексеевская",
                    Price = 11000
                },
                new ApartmentEntity()
                {
                    Id = 9,
                    Name = "Сдам 1 к.квартиру Новые дома.",
                    Price = 4500
                },
                new ApartmentEntity()
                {
                    Id = 10,
                    Name = "Аренда VIP 2-ух комнатной квартиры в Новострое",
                    Price = 9500
                },
                new ApartmentEntity()
                {
                    Id = 11,
                    Name = "Сдам в Центре 1 к. кв., 5 мин. метро, без комиссии, сквер-Стрелка!",
                    Price = 11000
                },
                new ApartmentEntity()
                {
                    Id = 12,
                    Name = "сдам 1 км квартиру в новострое",
                    Price = 7300
                },
                new ApartmentEntity()
                {
                    Id = 13,
                    Name = "Сдам 1 комнатную квартиру Победа(Алексеевка)",
                    Price = 8000
                },
                new ApartmentEntity()
                {
                    Id = 14,
                    Name = "Сдам 1 ком. кв. в новострое Салтовка МЖК метро ГероевТруда 5 мин",
                    Price = 7500
                },
                new ApartmentEntity()
                {
                    Id = 15,
                    Name = "Сдам 1 комнатную евроремонт Салтовка",
                    Price = 1100
                },
                new ApartmentEntity()
                {
                    Id = 16,
                    Name = "Сдам гостинку воробьевы горы",
                    Price = 6150
                });
        }
    }
}