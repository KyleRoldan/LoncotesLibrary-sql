using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    public partial class AddMaterialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Checkouts",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 2, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8470));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 7, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 9, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 4, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "Id", "GenreId", "MaterialName", "MaterialTypeId", "OutOfCirculationSince" },
                values: new object[,]
                {
                    { 5, 2, "Made up Material Name 5", 1, new DateTime(2023, 12, 31, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8520) },
                    { 6, 3, "Made up Material Name 6", 2, new DateTime(2024, 1, 6, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8520) },
                    { 7, 4, "Made up Material Name 7", 3, new DateTime(2024, 1, 3, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8520) },
                    { 8, 5, "Made up Material Name 8", 4, new DateTime(2024, 1, 8, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8530) },
                    { 9, 3, "Made up Material Name 9", 1, new DateTime(2024, 1, 5, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8530) },
                    { 10, 4, "Made up Material Name 10", 2, new DateTime(2024, 1, 1, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8530) },
                    { 11, 5, "Made up Material Name 11", 5, new DateTime(2024, 1, 10, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8540) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ReturnDate",
                table: "Checkouts",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "OutOfCirculationSince",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "OutOfCirculationSince",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "OutOfCirculationSince",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "OutOfCirculationSince",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
