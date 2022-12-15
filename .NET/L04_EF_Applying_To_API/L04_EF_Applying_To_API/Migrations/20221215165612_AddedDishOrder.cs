using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddedDishOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DishOrders",
                columns: table => new
                {
                    DishOrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LocalUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishOrders", x => x.DishOrderId);
                    table.ForeignKey(
                        name: "FK_DishOrders_Dishes_DishOrderId",
                        column: x => x.DishOrderId,
                        principalTable: "Dishes",
                        principalColumn: "DishId");
                    table.ForeignKey(
                        name: "FK_DishOrders_LocalUsers_LocalUserId",
                        column: x => x.LocalUserId,
                        principalTable: "LocalUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 15, 18, 56, 12, 477, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 15, 18, 56, 12, 477, DateTimeKind.Local).AddTicks(2792));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 15, 18, 56, 12, 477, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_LocalUserId",
                table: "DishOrders",
                column: "LocalUserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishOrders");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 8, 19, 37, 10, 319, DateTimeKind.Local).AddTicks(312));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 8, 19, 37, 10, 319, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 8, 19, 37, 10, 319, DateTimeKind.Local).AddTicks(361));
        }
    }
}
