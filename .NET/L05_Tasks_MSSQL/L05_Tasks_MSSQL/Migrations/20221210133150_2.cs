using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class _2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryBook_Books_BookId",
                table: "LibraryBook");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryBook",
                table: "LibraryBook");

            migrationBuilder.RenameTable(
                name: "LibraryBook",
                newName: "LibraryBooks");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryBook_BookId",
                table: "LibraryBooks",
                newName: "IX_LibraryBooks_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryBooks",
                table: "LibraryBooks",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UserBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LibraryBookId = table.Column<int>(type: "int", nullable: false),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    BookTaken = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookReturned = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Updated = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserBooks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserBooks_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(85), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(116) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(121), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(123) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(124), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(128), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(132), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(135), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(136) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(138), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(142), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(143) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(145), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(148), new DateTime(2022, 12, 10, 15, 31, 50, 726, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_UserId",
                table: "UserBooks",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryBooks_Books_BookId",
                table: "LibraryBooks",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LibraryBooks_Books_BookId",
                table: "LibraryBooks");

            migrationBuilder.DropTable(
                name: "UserBooks");

            migrationBuilder.DropPrimaryKey(
                name: "PK_LibraryBooks",
                table: "LibraryBooks");

            migrationBuilder.RenameTable(
                name: "LibraryBooks",
                newName: "LibraryBook");

            migrationBuilder.RenameIndex(
                name: "IX_LibraryBooks_BookId",
                table: "LibraryBook",
                newName: "IX_LibraryBook_BookId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_LibraryBook",
                table: "LibraryBook",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2803), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2837) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2842), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2843) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2845), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2847) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2849), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2850) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2852), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2854) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2856), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2857) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2859), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2860) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2862), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2864) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2865), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2867) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2869), new DateTime(2022, 12, 10, 15, 30, 19, 237, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.AddForeignKey(
                name: "FK_LibraryBook_Books_BookId",
                table: "LibraryBook",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
