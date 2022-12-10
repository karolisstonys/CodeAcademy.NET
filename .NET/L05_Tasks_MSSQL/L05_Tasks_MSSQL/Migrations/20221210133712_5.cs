using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class _5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1691), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1728) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1732), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1734) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1736), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1737) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1739), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1741) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1743), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1744) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1746), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1748) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1750), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1751) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1753), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1755) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1756), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1758) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1760), new DateTime(2022, 12, 10, 15, 36, 30, 555, DateTimeKind.Local).AddTicks(1761) });
        }
    }
}
