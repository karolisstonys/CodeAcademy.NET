using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedUpdatedDateTimeToDish : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDateTime",
                table: "Dishes",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 30, 20, 22, 18, 514, DateTimeKind.Local).AddTicks(8497), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 30, 20, 22, 18, 514, DateTimeKind.Local).AddTicks(8534), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                columns: new[] { "CreatedDateTime", "UpdatedDateTime" },
                values: new object[] { new DateTime(2022, 11, 30, 20, 22, 18, 514, DateTimeKind.Local).AddTicks(8536), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UpdatedDateTime",
                table: "Dishes");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2022, 11, 23, 21, 58, 16, 65, DateTimeKind.Local).AddTicks(4665));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2022, 11, 23, 21, 58, 16, 65, DateTimeKind.Local).AddTicks(4833));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2022, 11, 23, 21, 58, 16, 65, DateTimeKind.Local).AddTicks(4835));
        }
    }
}
