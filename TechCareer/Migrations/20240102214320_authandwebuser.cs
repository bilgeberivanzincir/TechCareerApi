using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TechCareer.Migrations
{
    public partial class authandwebuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "WebUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2024, 1, 3, 0, 43, 19, 944, DateTimeKind.Local).AddTicks(4674));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2024, 1, 3, 0, 43, 19, 944, DateTimeKind.Local).AddTicks(4682));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2024, 1, 3, 0, 43, 19, 944, DateTimeKind.Local).AddTicks(4684));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "WebUsers");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddDate",
                value: new DateTime(2023, 12, 30, 15, 42, 20, 545, DateTimeKind.Local).AddTicks(9234));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddDate",
                value: new DateTime(2023, 12, 30, 15, 42, 20, 545, DateTimeKind.Local).AddTicks(9243));

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddDate",
                value: new DateTime(2023, 12, 30, 15, 42, 20, 545, DateTimeKind.Local).AddTicks(9245));
        }
    }
}
