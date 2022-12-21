using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class updatedSpiceLevelToOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpiceLevel",
                table: "Dishes",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 21, 18, 21, 56, 691, DateTimeKind.Local).AddTicks(5799));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 21, 18, 21, 56, 691, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3,
                column: "CreatedDateTime",
                value: new DateTime(2022, 12, 21, 18, 21, 56, 691, DateTimeKind.Local).AddTicks(6046));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpiceLevel",
                table: "Dishes",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

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
        }
    }
}
