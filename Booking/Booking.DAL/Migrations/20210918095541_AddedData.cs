using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.DAL.Migrations
{
    public partial class AddedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Apartments",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[] { 2, "Аренда 3-x комнатной квартиры в центре", 15500m });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "5e489e49-7011-47ba-af14-acbd9007e402");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "e81e8c68-d3a7-4c44-9800-8fe483ed50d4");

            migrationBuilder.InsertData(
                table: "ApartmentDetails",
                columns: new[] { "Id", "ApartmentEntityId", "DetailsEntityId", "Value" },
                values: new object[,]
                {
                    { 5, 2, 1, "Сумська вулиця, 18-а, Харків, Харківська область, 61106" },
                    { 6, 2, 2, "3" },
                    { 7, 2, 3, "3" },
                    { 8, 2, 4, "105" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ApartmentDetails",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Apartments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "2d3abd2c-2c1e-4340-96ba-f02c23aab798");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "356dec19-5fad-4493-9216-c882eea630f9");
        }
    }
}
