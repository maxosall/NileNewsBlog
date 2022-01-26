using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nile.API.Migrations
{
    public partial class addCommentListRel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 52, 4, 500, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 52, 4, 500, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 52, 4, 500, DateTimeKind.Local).AddTicks(1605));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 52, 4, 500, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 52, 4, 500, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 52, 4, 500, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 52, 4, 500, DateTimeKind.Local).AddTicks(2006));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 52, 4, 500, DateTimeKind.Local).AddTicks(2085));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(704));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(922));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(990));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(1149));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(1219));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(1292));
        }
    }
}
