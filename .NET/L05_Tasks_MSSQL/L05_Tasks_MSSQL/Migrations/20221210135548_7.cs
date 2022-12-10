using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class _7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(233), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(269) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(272), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(273) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(275), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(277) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(279), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(281) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(283), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(284) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(286), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(288) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(290), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(293), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(295) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(297), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(298) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(300), new DateTime(2022, 12, 10, 15, 55, 48, 385, DateTimeKind.Local).AddTicks(302) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "FullName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Author",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7564), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7597) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7605), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7607) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7609), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7611) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7613), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7614) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7616), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7618) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7620), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7621) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7623), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7625) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7626), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7628) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7630), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7631) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7633), new DateTime(2022, 12, 10, 15, 37, 30, 869, DateTimeKind.Local).AddTicks(7635) });
        }
    }
}
