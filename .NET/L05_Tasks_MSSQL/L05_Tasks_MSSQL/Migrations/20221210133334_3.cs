using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BookId",
                table: "UserBooks");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6746), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6781) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6785), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6789), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6792), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6796), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6797) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6799), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6848) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6851), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6853) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6855), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6856) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6858), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6860) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6862), new DateTime(2022, 12, 10, 15, 33, 34, 623, DateTimeKind.Local).AddTicks(6863) });

            migrationBuilder.CreateIndex(
                name: "IX_UserBooks_LibraryBookId",
                table: "UserBooks",
                column: "LibraryBookId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserBooks_LibraryBooks_LibraryBookId",
                table: "UserBooks",
                column: "LibraryBookId",
                principalTable: "LibraryBooks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserBooks_LibraryBooks_LibraryBookId",
                table: "UserBooks");

            migrationBuilder.DropIndex(
                name: "IX_UserBooks_LibraryBookId",
                table: "UserBooks");

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "UserBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
        }
    }
}
