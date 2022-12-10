using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class _1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ECoverType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableBooksInLibrary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LibraryBook",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    IsTaken = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryBook", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryBook_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "AvailableBooksInLibrary", "Created", "ECoverType", "PublishYear", "Title", "Updated" },
                values: new object[,]
                {
                    { 1, "Marcel Proust", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2803), "Paperback", 2001, "In Search of Lost Time", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2837) },
                    { 2, "James Joyce", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2842), "Hardcover", 2002, "Ulysses", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2843) },
                    { 3, "Miguel de Cervantes", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2845), "Electronic", 2003, "Don Quixote", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2847) },
                    { 4, "Gabriel Garcia Marquez", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2849), "Hardcover", 2004, "One Hundred Years of Solitude", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2850) },
                    { 5, "F. Scott Fitzgerald", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2852), "Hardcover", 2005, "The Great Gatsby", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2854) },
                    { 6, "Herman Melville", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2856), "Paperback", 2006, "Moby Dick", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2857) },
                    { 7, "Leo Tolstoy", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2859), "Paperback", 2007, "War and Peace", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2860) },
                    { 8, "William Shakespeare", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2862), "Hardcover", 2008, "Hamlet", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2864) },
                    { 9, "William Shakespeare", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2865), "Hardcover", 2009, "King Lear", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2867) },
                    { 10, "William Shakespeare", 0, new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2869), "Paperback", 2010, "The Tempest", new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2870) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryBook_BookId",
                table: "LibraryBook",
                column: "BookId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LibraryBook");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
