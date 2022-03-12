using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nile.API.Migrations
{
    public partial class AuthDep : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2022, 2, 3, 22, 56, 57, 49, DateTimeKind.Local).AddTicks(9351));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2022, 2, 3, 22, 56, 57, 49, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2022, 2, 3, 22, 56, 57, 49, DateTimeKind.Local).AddTicks(9593));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2022, 2, 3, 22, 56, 57, 49, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2022, 2, 3, 22, 56, 57, 49, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2022, 2, 3, 22, 56, 57, 49, DateTimeKind.Local).AddTicks(9877));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2022, 2, 3, 22, 56, 57, 49, DateTimeKind.Local).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2022, 2, 3, 22, 56, 57, 50, DateTimeKind.Local).AddTicks(46));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 57, 24, 261, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 57, 24, 261, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 57, 24, 261, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 57, 24, 261, DateTimeKind.Local).AddTicks(7739));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 57, 24, 261, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 57, 24, 261, DateTimeKind.Local).AddTicks(7922));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 57, 24, 261, DateTimeKind.Local).AddTicks(7995));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 57, 24, 261, DateTimeKind.Local).AddTicks(8063));
        }
    }
}
