using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nile.API.Migrations
{
    public partial class rename_PublisheDate_to_DatePulished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PublishDate",
                table: "Articles",
                newName: "DatePublished");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Articles",
                type: "nvarchar(500)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategory",
                columns: table => new
                {
                    ArticlesArticleId = table.Column<int>(type: "INTEGER", nullable: false),
                    CategoriesId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategory", x => new { x.ArticlesArticleId, x.CategoriesId });
                    table.ForeignKey(
                        name: "FK_ArticleCategory_Articles_ArticlesArticleId",
                        column: x => x.ArticlesArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleCategory_Category_CategoriesId",
                        column: x => x.CategoriesId,
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 1,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 17, 2, 48, 5, 369, DateTimeKind.Local).AddTicks(3196));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 2,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 17, 2, 48, 5, 369, DateTimeKind.Local).AddTicks(3471));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 3,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 17, 2, 48, 5, 369, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 4,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 17, 2, 48, 5, 369, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 5,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 17, 2, 48, 5, 369, DateTimeKind.Local).AddTicks(3809));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 6,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 17, 2, 48, 5, 369, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 7,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 17, 2, 48, 5, 369, DateTimeKind.Local).AddTicks(4043));

            migrationBuilder.UpdateData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: 8,
                column: "DateOfBirth",
                value: new DateTime(2023, 5, 17, 2, 48, 5, 369, DateTimeKind.Local).AddTicks(4144));

            migrationBuilder.CreateIndex(
                name: "IX_ArticleCategory_CategoriesId",
                table: "ArticleCategory",
                column: "CategoriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleCategory");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.RenameColumn(
                name: "DatePublished",
                table: "Articles",
                newName: "PublishDate");

            migrationBuilder.AlterColumn<string>(
                name: "Content",
                table: "Articles",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)");

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
    }
}
