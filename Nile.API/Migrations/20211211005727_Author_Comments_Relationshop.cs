using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nile.API.Migrations
{
    public partial class Author_Comments_Relationshop : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AuthorId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Authors_AuthorId",
                table: "Comments",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Authors_AuthorId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_AuthorId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "AuthorId",
                table: "Comments");

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
    }
}
