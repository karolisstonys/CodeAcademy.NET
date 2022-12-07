using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedLocalUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Password = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 7, 18, 46, 18, 860, DateTimeKind.Local).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 7, 18, 46, 18, 860, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 7, 18, 46, 18, 860, DateTimeKind.Local).AddTicks(280));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2022, 11, 30, 20, 22, 18, 514, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2022, 11, 30, 20, 22, 18, 514, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2022, 11, 30, 20, 22, 18, 514, DateTimeKind.Local).AddTicks(8536));
        }
    }
}
