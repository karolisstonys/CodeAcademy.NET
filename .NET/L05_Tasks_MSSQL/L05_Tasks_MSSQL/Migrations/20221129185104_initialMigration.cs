using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class initialMigration : Migration
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
                    PublishYear = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "ECoverType", "PublishYear", "Title" },
                values: new object[,]
                {
                    { 1, "Marcel Proust", "Paperback", 2001, "In Search of Lost Time" },
                    { 2, "James Joyce", "Hardcover", 2002, "Ulysses" },
                    { 3, "Miguel de Cervantes", "Electronic", 2003, "Don Quixote" },
                    { 4, "Gabriel Garcia Marquez", "Hardcover", 2004, "One Hundred Years of Solitude" },
                    { 5, "F. Scott Fitzgerald", "Hardcover", 2005, "The Great Gatsby" },
                    { 6, "Herman Melville", "Paperback", 2006, "Moby Dick" },
                    { 7, "Leo Tolstoy", "Paperback", 2007, "War and Peace" },
                    { 8, "William Shakespeare", "Hardcover", 2008, "Hamlet" },
                    { 9, "William Shakespeare", "Hardcover", 2009, "King Lear" },
                    { 10, "William Shakespeare", "Paperback", 2010, "The Tempest" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");
        }
    }
}
