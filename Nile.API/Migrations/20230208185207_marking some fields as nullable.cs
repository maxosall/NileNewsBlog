using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nile.API.Migrations
{
    public partial class markingsomefieldsasnullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Authors",
                type: "varchar(450)",
                maxLength: 450,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(450)",
                oldMaxLength: 450);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 52, 4, 696, DateTimeKind.Local).AddTicks(3899));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 52, 4, 696, DateTimeKind.Local).AddTicks(4049));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 52, 4, 696, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 52, 4, 696, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 52, 4, 696, DateTimeKind.Local).AddTicks(4305));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 52, 4, 696, DateTimeKind.Local).AddTicks(4412));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 52, 4, 696, DateTimeKind.Local).AddTicks(4492));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 52, 4, 696, DateTimeKind.Local).AddTicks(4569));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Bio",
                table: "Authors",
                type: "varchar(450)",
                maxLength: 450,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(450)",
                oldMaxLength: 450,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 19, 12, 921, DateTimeKind.Local).AddTicks(1112));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 19, 12, 921, DateTimeKind.Local).AddTicks(1246));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 19, 12, 921, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 19, 12, 921, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 19, 12, 921, DateTimeKind.Local).AddTicks(1450));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 19, 12, 921, DateTimeKind.Local).AddTicks(1536));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 19, 12, 921, DateTimeKind.Local).AddTicks(1603));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2023, 2, 8, 20, 19, 12, 921, DateTimeKind.Local).AddTicks(1668));
        }
    }
}
