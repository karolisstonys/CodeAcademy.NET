using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedPasswordsAndAddedRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Password",
                table: "LocalUsers",
                newName: "Role");

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "LocalUsers",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "LocalUsers",
                type: "BLOB",
                nullable: false,
                defaultValue: new byte[0]);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "LocalUsers");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "LocalUsers");

            migrationBuilder.RenameColumn(
                name: "Role",
                table: "LocalUsers",
                newName: "Password");

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
    }
}
