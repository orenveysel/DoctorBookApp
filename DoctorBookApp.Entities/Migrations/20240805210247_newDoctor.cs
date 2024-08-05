using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorBookApp.Entities.Migrations
{
    /// <inheritdoc />
    public partial class newDoctor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastName",
                value: "Yilmaz");

            migrationBuilder.InsertData(
                table: "Doctors",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[] { 2, "Ozturk", "Ayse" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Doctors",
                keyColumn: "Id",
                keyValue: 1,
                column: "LastName",
                value: "Veli");
        }
    }
}
