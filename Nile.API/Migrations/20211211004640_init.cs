using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Nile.API.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentName = table.Column<string>(type: "varchar(65)", maxLength: 65, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: true),
                    Bio = table.Column<string>(type: "varchar(450)", maxLength: 450, nullable: true),
                    PhotoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                    table.ForeignKey(
                        name: "FK_Authors_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.ArticleId);
                    table.ForeignKey(
                        name: "FK_Articles_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentContent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ArticleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "DepartmentId", "DepartmentName" },
                values: new object[,]
                {
                    { 1, "Sport" },
                    { 2, "Bussness and Economy" },
                    { 3, "Politics" },
                    { 4, "Science and Tech" }
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "Bio", "DateOfBirth", "DepartmentId", "Email", "FirstName", "Gender", "LastName", "PhotoPath" },
                values: new object[,]
                {
                    { 1, "i'm jornalist and a former Software Engeer", new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(704), 4, "maxo@gmail.com", "Ali", 0, "Sall", "img/a_7.jfif" },
                    { 2, "i'm have Degree in busness and i am a writer", new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(846), 2, "fatima@gmail.com", "fatima ", 1, "kane", "img/a_6jfif.jfif" },
                    { 3, "I'm a Writer who graduated from XbU with Polilic science Degree ", new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(922), 3, "habib@gmail.com", "habib ", 0, "Sall", "img/a_2.jfif" },
                    { 4, "i am a journalist with CS background", new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(990), 4, "maxo@gmail.com", "Nancy ", 1, "fay", "img/a_1.jfif" },
                    { 5, "I am a Sport Analyist and a writer", new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(1058), 1, "nabou@gmail.com", "nabou", 1, "fall", "img/a_9.jfif" },
                    { 6, "I am a Jornalist who is intrested in tech and sciense", new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(1149), 4, "nabou@gmail.com", "Noora", 1, "Disllo", "img/black_q.jpg" },
                    { 7, "I am polictic analysist", new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(1219), 3, "nabou@gmail.com", "Anwar", 0, "Sadiq", "img/a_3.jfif" },
                    { 8, "I am polictic analysist", new DateTime(2021, 12, 11, 2, 46, 38, 139, DateTimeKind.Local).AddTicks(1292), 3, "Mansour@gmail.com", "Mansour", 0, "Sall", "img/a_3.jfif" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_AuthorId",
                table: "Articles",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_DepartmentId",
                table: "Authors",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_ArticleId",
                table: "Comments",
                column: "ArticleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Departments");
        }
    }
}
