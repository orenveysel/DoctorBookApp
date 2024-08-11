using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorBookApp.Entities.Migrations
{
    /// <inheritdoc />
    public partial class login : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Doctors",
                newName: "FirstName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Customers",
                newName: "FirstName");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Customers",
                type: "tinyint(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(1)");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Customers",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Customers",
                type: "varchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Customers",
                type: "varchar(256)",
                maxLength: 256,
                nullable: false,
                defaultValue: "")
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Customers");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Doctors",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Customers",
                newName: "Name");

            migrationBuilder.AlterColumn<bool>(
                name: "Gender",
                table: "Customers",
                type: "tinyint(1)",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "tinyint(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
