using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoncotesLibrary.Migrations
{
    public partial class Patron : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Patron_PatronId",
                table: "Checkouts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patron",
                table: "Patron");

            migrationBuilder.RenameTable(
                name: "Patron",
                newName: "Patrons");

            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Patrons",
                newName: "IsActive");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons",
                column: "Id");

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

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialTypeId",
                table: "Materials",
                column: "MaterialTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Patrons_PatronId",
                table: "Checkouts",
                column: "PatronId",
                principalTable: "Patrons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_MaterialTypes_MaterialTypeId",
                table: "Materials",
                column: "MaterialTypeId",
                principalTable: "MaterialTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Checkouts_Patrons_PatronId",
                table: "Checkouts");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_MaterialTypes_MaterialTypeId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_MaterialTypeId",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patrons",
                table: "Patrons");

            migrationBuilder.RenameTable(
                name: "Patrons",
                newName: "Patron");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Patron",
                newName: "isActive");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patron",
                table: "Patron",
                column: "Id");

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

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 5,
                column: "OutOfCirculationSince",
                value: new DateTime(2023, 12, 31, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 6,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 6, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 7,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 3, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 8,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 8, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 9,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 5, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 10,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 1, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "Materials",
                keyColumn: "Id",
                keyValue: 11,
                column: "OutOfCirculationSince",
                value: new DateTime(2024, 1, 10, 12, 27, 37, 567, DateTimeKind.Local).AddTicks(8540));

            migrationBuilder.AddForeignKey(
                name: "FK_Checkouts_Patron_PatronId",
                table: "Checkouts",
                column: "PatronId",
                principalTable: "Patron",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
