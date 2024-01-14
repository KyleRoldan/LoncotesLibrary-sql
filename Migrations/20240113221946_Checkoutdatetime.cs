using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    public partial class Checkoutdatetime : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Checkouts",
                columns: new[] { "Id", "CheckoutDate", "MaterialId", "PatronId", "ReturnDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 1, 1, null },
                    { 2, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 2, 2, null },
                    { 3, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 3, 3, null },
                    { 4, new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local), 4, 4, null }
                });

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 3, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8660));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 8, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 10, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 5, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 1, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 7, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8680));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 4, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 9, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 6, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 2, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 11, 17, 19, 46, 476, DateTimeKind.Local).AddTicks(8690));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 3, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 8, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 10, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 5, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 1, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 7, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 4, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 9, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 6, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 2, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 11, 14, 12, 11, 336, DateTimeKind.Local).AddTicks(7720));
        }
    }
}
