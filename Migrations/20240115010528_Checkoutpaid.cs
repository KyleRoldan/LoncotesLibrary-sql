using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    public partial class Checkoutpaid : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "OutOfCirculationSince",
                table: "Materials",
                type: "timestamp without time zone",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone");

            migrationBuilder.AddColumn<bool>(
                name: "Paid",
                table: "Checkouts",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckoutDate", "Paid" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckoutDate", "Paid" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckoutDate", "Paid" },
                values: new object[] { new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local), true });

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckoutDate",
                value: new DateTime(2024, 1, 14, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 1,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 4, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 2,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 9, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 3,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 11, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 4,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 6, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 2, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 8, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 5, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 10, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 7, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 3, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 12, 20, 5, 28, 613, DateTimeKind.Local).AddTicks(560));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Paid",
                table: "Checkouts");

            migrationBuilder.AlterColumn<DateTime>(
                name: "OutOfCirculationSince",
                table: "Materials",
                type: "timestamp without time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "timestamp without time zone",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 1,
                column: "CheckoutDate",
                value: new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 2,
                column: "CheckoutDate",
                value: new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 3,
                column: "CheckoutDate",
                value: new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Checkouts",
                keyColumn: "Id",
                keyValue: 4,
                column: "CheckoutDate",
                value: new DateTime(2024, 1, 13, 0, 0, 0, 0, DateTimeKind.Local));

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
    }
}
