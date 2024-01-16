using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    public partial class extra : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "GenreId", "MaterialName", "MaterialTypeId", "OutOfCirculationSince" },
                values: new object[] { 12, 5, "Made up Material Name 12", 5, new DateTime(2024, 1, 15, 23, 56, 55, 59, DateTimeKind.Local).AddTicks(150) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
