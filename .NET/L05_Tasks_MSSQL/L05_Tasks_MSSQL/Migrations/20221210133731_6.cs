using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class _6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(356), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(391) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(396), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(397) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(399), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(400) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(402), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(404) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(406), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(407) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(409), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(411) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(412), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(414) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(416), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(417) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(419), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(421) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(422), new DateTime(2022, 12, 10, 15, 37, 12, 435, DateTimeKind.Local).AddTicks(424) });
        }
    }
}
