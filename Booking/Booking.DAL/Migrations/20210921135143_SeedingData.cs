using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.DAL.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "Value",
                value: "Новые дома 25 микрорайон");

            migrationBuilder.UpdateData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "Value",
                value: "45");

            migrationBuilder.InsertData(
                table: "ApartmentDetails",
                columns: new[] { "Id", "ApartmentId", "DetailsId", "Value" },
                values: new object[] { 29, 1, 1, "проспект Л. Свободы." });

            migrationBuilder.InsertData(
                table: "ApartmentPhotos",
                columns: new[] { "Id", "ApartmentId", "Path" },
                values: new object[,]
                {
                    { 6, 2, "ApartmentPhotos/apartment23.jpg" },
                    { 5, 2, "ApartmentPhotos/apartment22.jpg" },
                    { 4, 2, "ApartmentPhotos/apartment21.jpg" }
                });

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Сдам 2 к. кв Новые дома 25 микрорайон", 6500m });

            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { 16, "Сдам гостинку воробьевы горы", 6150m },
                    { 15, "Сдам 1 комнатную евроремонт Салтовка", 1100m },
                    { 13, "Сдам 1 комнатную квартиру Победа(Алексеевка)", 8000m },
                    { 14, "Сдам 1 ком. кв. в новострое Салтовка МЖК метро ГероевТруда 5 мин", 7500m },
                    { 11, "Сдам в Центре 1 к. кв., 5 мин. метро, без комиссии, сквер-Стрелка!", 11000m },
                    { 10, "Аренда VIP 2-ух комнатной квартиры в Новострое", 9500m },
                    { 9, "Сдам 1 к.квартиру Новые дома.", 4500m },
                    { 8, "Сдам 1-к квартиру, рядом метро Алексеевская", 11000m },
                    { 7, "Сдам 1к квартиру новострой ЖК Квартет возле ТРК Украина", 7300m },
                    { 6, "Сдам 1к кв в ЖК Ньютона, м,Дворец спорта", 8000m },
                    { 5, "Сдам гостинку", 3000m },
                    { 4, "Сдам 3-ком.квартиру на Сухумской", 27000m },
                    { 12, "сдам 1 км квартиру в новострое", 7300m },
                    { 3, "Сдам 2-х комнатную квартиру (71 м2), 5 минут от м. Университет", 15000m }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7e7b1b20-6296-48dc-95d5-c586b1b6b10c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4c8df897-9a7b-4523-8365-dd9fb8aee2fa");

            migrationBuilder.InsertData(
                table: "ApartmentDetails",
                columns: new[] { "Id", "ApartmentId", "DetailsId", "Value" },
                values: new object[,]
                {
                    { 64, 16, 4, "87" },
                    { 26, 7, 2, "10" },
                    { 45, 12, 1, "Победа(Алексеевка)" },
                    { 28, 7, 4, "42" },
                    { 54, 14, 2, "5" },
                    { 53, 14, 1, "ул Бучмы, метро Героев Труда" },
                    { 30, 8, 2, "9" },
                    { 31, 8, 3, "1" },
                    { 32, 8, 4, "34" },
                    { 52, 13, 4, "57" },
                    { 33, 9, 1, "Новые Дома" },
                    { 34, 9, 2, "3" },
                    { 35, 9, 3, "1" },
                    { 36, 9, 4, "35" },
                    { 63, 16, 3, "2" },
                    { 51, 13, 3, "1" },
                    { 50, 13, 2, "7" },
                    { 37, 10, 1, "Центр м. Исторический музей" },
                    { 38, 10, 2, "3" },
                    { 39, 10, 3, "1" },
                    { 40, 10, 4, "40" },
                    { 49, 13, 1, "в новострое Салтовка МЖК метро ГероевТруда" },
                    { 41, 11, 1, "Московский район" },
                    { 42, 11, 2, "10" },
                    { 43, 11, 3, "1" },
                    { 44, 11, 4, "42" },
                    { 48, 12, 4, "38" },
                    { 47, 12, 3, "1" },
                    { 25, 7, 1, "ЖК Квартет возле ТРК Украина" },
                    { 55, 14, 3, "1" },
                    { 27, 7, 3, "2" },
                    { 60, 15, 4, "19" },
                    { 62, 16, 2, "2" },
                    { 61, 16, 1, "Цілиноградська вулиця, 48-в, Харків, Харківська область, 61202" },
                    { 9, 3, 1, "м.Университет" },
                    { 10, 3, 2, "2" },
                    { 11, 3, 3, "2" },
                    { 12, 3, 4, "71" },
                    { 13, 4, 1, "ул.Сумская,Новострой" },
                    { 14, 4, 2, "10" },
                    { 15, 4, 3, "2" },
                    { 16, 4, 4, "95" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentDetails",
                columns: new[] { "Id", "ApartmentId", "DetailsId", "Value" },
                values: new object[,]
                {
                    { 56, 14, 4, "38" },
                    { 59, 15, 3, "12" },
                    { 58, 15, 2, "1" },
                    { 46, 12, 2, "7" },
                    { 18, 5, 2, "1" },
                    { 19, 5, 3, "1" },
                    { 24, 6, 4, "37" },
                    { 23, 6, 3, "1" },
                    { 20, 5, 4, "18" },
                    { 57, 15, 1, "воробьевы горы" },
                    { 22, 6, 2, "1" },
                    { 21, 6, 1, "ЖК Ньютона, м,Дворец спорта" },
                    { 17, 5, 1, "улица Дидро 30,метро Академика Павлова" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentPhotos",
                columns: new[] { "Id", "ApartmentId", "Path" },
                values: new object[,]
                {
                    { 37, 13, "ApartmentPhotos/apartment131.jpg" },
                    { 44, 15, "ApartmentPhotos/apartment152.jpg" },
                    { 42, 14, "ApartmentPhotos/apartment143.jpg" },
                    { 39, 13, "ApartmentPhotos/apartment133.jpg" },
                    { 48, 16, "ApartmentPhotos/apartment163.jpg" },
                    { 47, 16, "ApartmentPhotos/apartment162.jpg" },
                    { 46, 16, "ApartmentPhotos/apartment161.jpg" },
                    { 45, 15, "ApartmentPhotos/apartment153.jpg" },
                    { 41, 14, "ApartmentPhotos/apartment142.jpg" },
                    { 40, 14, "ApartmentPhotos/apartment141.jpg" },
                    { 38, 13, "ApartmentPhotos/apartment132.jpg" },
                    { 43, 15, "ApartmentPhotos/apartment151.jpg" },
                    { 28, 10, "ApartmentPhotos/apartment101.jpg" },
                    { 35, 12, "ApartmentPhotos/apartment122.jpg" },
                    { 8, 3, "ApartmentPhotos/apartment32.jpg" },
                    { 9, 3, "ApartmentPhotos/apartment33.jpg" },
                    { 10, 4, "ApartmentPhotos/apartment41.jpg" },
                    { 11, 4, "ApartmentPhotos/apartment42.jpg" },
                    { 12, 4, "ApartmentPhotos/apartment43.jpg" },
                    { 13, 5, "ApartmentPhotos/apartment51.jpg" },
                    { 14, 5, "ApartmentPhotos/apartment52.jpg" },
                    { 15, 5, "ApartmentPhotos/apartment53.jpg" },
                    { 16, 6, "ApartmentPhotos/apartment61.jpg" },
                    { 17, 6, "ApartmentPhotos/apartment62.jpg" },
                    { 18, 6, "ApartmentPhotos/apartment63.jpg" },
                    { 19, 7, "ApartmentPhotos/apartment71.jpg" },
                    { 36, 12, "ApartmentPhotos/apartment123.jpg" },
                    { 20, 7, "ApartmentPhotos/apartment72.jpg" },
                    { 22, 8, "ApartmentPhotos/apartment81.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ApartmentPhotos",
                columns: new[] { "Id", "ApartmentId", "Path" },
                values: new object[,]
                {
                    { 23, 8, "ApartmentPhotos/apartment82.jpg" },
                    { 24, 8, "ApartmentPhotos/apartment83.jpg" },
                    { 25, 9, "ApartmentPhotos/apartment91.jpg" },
                    { 26, 9, "ApartmentPhotos/apartment92.jpg" },
                    { 27, 9, "ApartmentPhotos/apartment93.jpg" },
                    { 29, 10, "ApartmentPhotos/apartment102.jpg" },
                    { 30, 10, "ApartmentPhotos/apartment103.jpg" },
                    { 31, 11, "ApartmentPhotos/apartment111.jpg" },
                    { 32, 11, "ApartmentPhotos/apartment112.jpg" },
                    { 33, 11, "ApartmentPhotos/apartment113.jpg" },
                    { 34, 12, "ApartmentPhotos/apartment121.jpg" },
                    { 21, 7, "ApartmentPhotos/apartment73.jpg" },
                    { 7, 3, "ApartmentPhotos/apartment31.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ApartmentPhotos",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 5,
                column: "Value",
                value: "Сумська вулиця, 18-а, Харків, Харківська область, 61106");

            migrationBuilder.UpdateData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 8,
                column: "Value",
                value: "105");

            migrationBuilder.UpdateData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Price" },
                values: new object[] { "Аренда 3-x комнатной квартиры в центре", 15500m });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8f4befdd-5528-4ebb-a21f-41cfe07bcc45");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a0b28631-afaf-4aaf-9259-a609c17d4f74");
        }
    }
}
