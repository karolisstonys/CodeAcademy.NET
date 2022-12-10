using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Author = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ECoverType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PublishYear = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AvailableBooksInLibrary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.ISBN);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                name: "LibraryBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookISBN = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IsTaken = table.Column<bool>(type: "bit", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LibraryBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_LibraryBooks_Books_BookISBN",
                        column: x => x.BookISBN,
                        principalTable: "Books",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LibraryBookId = table.Column<int>(type: "int", nullable: false),
                    BookTaken = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookReturned = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBooks_LibraryBooks_LibraryBookId",
                        column: x => x.LibraryBookId,
                        principalTable: "LibraryBooks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserBooks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "ISBN", "Author", "AvailableBooksInLibrary", "Created", "ECoverType", "PublishYear", "Title", "Updated" },
                values: new object[,]
                {
                    { "0020198817", "F. Scott Fitzgerald", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6994), "Paperback", 1992, "The Great Gatsby", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6996) },
                    { "0439136350", "Rowling, J. K.", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7008), "Hardcover", 1999, "Harry Potter And The Prisoner Of Azkaban", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7010) },
                    { "0451526929", "William Shakespeare", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7005), "Paperback", 1998, "Hamlet", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7006) },
                    { "0451528905", "Miguel de Cervantes", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6987), "Paperback", 2003, "Don Quixote", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6989) },
                    { "0553211765", "Charles Dickens", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6937), "Hardcover", 1989, "A Tale of Two Cities", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6975) },
                    { "0553213113", "Herman Melville", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6998), "Paperback", 1981, "Moby Dick", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6999) },
                    { "0786275391", "Antoine de Saint-Exupery", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6980), "Hardcover", 2005, "The Little Prince", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6982) },
                    { "0847980790", "Agatha Christie", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6991), "Paperback", 1939, "And Then There Were None", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6993) },
                    { "1400079985", "Leo Tolstoy", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7001), "Paperback", 2008, "War and Peace", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7003) },
                    { "1856134032", "Rowling, J. K.", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6984), "Hardcover", 1997, "Harry Potter and The Philosopher's Stone", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6986) },
                    { "1856136124", "Rowling, J. K.", 0, new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7012), "Paperback", 1998, "Harry Potter and the Chamber of Secrets", new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7013) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_LibraryBooks_BookISBN",
                table: "LibraryBooks",
                column: "BookISBN");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_LibraryBookId",
                table: "UserBooks",
                column: "LibraryBookId");

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_UserId",
                table: "UserBooks",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserBooks");

            migrationBuilder.DropTable(
                name: "LibraryBooks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
