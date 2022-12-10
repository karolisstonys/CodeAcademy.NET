using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
