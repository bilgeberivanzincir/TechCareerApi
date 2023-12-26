using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareer.Migrations
{
    public partial class addedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BirtDate",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddDate",
                table: "Employees",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddDate", "Address", "BirthDate", "City", "FirstName", "LastName" },
                values: new object[] { 1, new DateTime(2023, 12, 27, 0, 54, 7, 718, DateTimeKind.Local).AddTicks(7780), "Kadıköy", new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "İstanbul", "Bilge Berivan", "Zincir" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddDate", "Address", "BirthDate", "City", "FirstName", "LastName" },
                values: new object[] { 2, new DateTime(2023, 12, 27, 0, 54, 7, 718, DateTimeKind.Local).AddTicks(7794), "Beyoğlu", new DateTime(2001, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "İstanbul", "Aykut", "Karakuzu" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AddDate", "Address", "BirthDate", "City", "FirstName", "LastName" },
                values: new object[] { 3, new DateTime(2023, 12, 27, 0, 54, 7, 718, DateTimeKind.Local).AddTicks(7797), "Kadıköy", new DateTime(2000, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "İstanbul", "Derin ", "Çağdaş" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Employees");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "AddDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirtDate",
                table: "Employees",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
