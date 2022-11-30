using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class addedCreatedAndUpdatedToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Updated",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(991), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1060), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1064), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1068), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1071), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1075), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1078), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1082), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1085), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1089), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1090) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Created",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Updated",
                table: "Books");
        }
    }
}
