using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.DAL.Migrations
{
    public partial class RenamedEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentDetails_Apartments_ApartmentEntityId",
                table: "ApartmentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentDetails_DetailsEntities_DetailsEntityId",
                table: "ApartmentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DetailsEntities",
                table: "DetailsEntities");

            migrationBuilder.RenameTable(
                name: "DetailsEntities",
                newName: "Details");

            migrationBuilder.RenameColumn(
                name: "DetailsEntityId",
                table: "ApartmentDetails",
                newName: "DetailsId");

            migrationBuilder.RenameColumn(
                name: "ApartmentEntityId",
                table: "ApartmentDetails",
                newName: "ApartmentId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentDetails_DetailsEntityId",
                table: "ApartmentDetails",
                newName: "IX_ApartmentDetails_DetailsId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentDetails_ApartmentEntityId",
                table: "ApartmentDetails",
                newName: "IX_ApartmentDetails_ApartmentId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Details",
                table: "Details",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentDetails_Apartments_ApartmentId",
                table: "ApartmentDetails",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentDetails_Details_DetailsId",
                table: "ApartmentDetails",
                column: "DetailsId",
                principalTable: "Details",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentDetails_Apartments_ApartmentId",
                table: "ApartmentDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_ApartmentDetails_Details_DetailsId",
                table: "ApartmentDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Details",
                table: "Details");

            migrationBuilder.RenameTable(
                name: "Details",
                newName: "DetailsEntities");

            migrationBuilder.RenameColumn(
                name: "DetailsId",
                table: "ApartmentDetails",
                newName: "DetailsEntityId");

            migrationBuilder.RenameColumn(
                name: "ApartmentId",
                table: "ApartmentDetails",
                newName: "ApartmentEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentDetails_DetailsId",
                table: "ApartmentDetails",
                newName: "IX_ApartmentDetails_DetailsEntityId");

            migrationBuilder.RenameIndex(
                name: "IX_ApartmentDetails_ApartmentId",
                table: "ApartmentDetails",
                newName: "IX_ApartmentDetails_ApartmentEntityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DetailsEntities",
                table: "DetailsEntities",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "9a688327-85e3-48e8-b1d9-7881884e5cb8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "eef1dc51-2872-4315-96d5-2deb5d7c0cbc");

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentDetails_Apartments_ApartmentEntityId",
                table: "ApartmentDetails",
                column: "ApartmentEntityId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ApartmentDetails_DetailsEntities_DetailsEntityId",
                table: "ApartmentDetails",
                column: "DetailsEntityId",
                principalTable: "DetailsEntities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
