using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorBookApp.Entities.Migrations
{
    /// <inheritdoc />
    public partial class last2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PhoneNumber",
                table: "Customers",
                type: "bigint",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldFixedLength: true,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<long>(
                name: "NationalId",
                table: "Customers",
                type: "bigint",
                fixedLength: true,
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldFixedLength: true,
                oldMaxLength: 11);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PhoneNumber",
                table: "Customers",
                type: "int",
                fixedLength: true,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldFixedLength: true,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<int>(
                name: "NationalId",
                table: "Customers",
                type: "int",
                fixedLength: true,
                maxLength: 11,
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldFixedLength: true,
                oldMaxLength: 11);
        }
    }
}
