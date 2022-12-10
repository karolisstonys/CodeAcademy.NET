using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class _8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5221), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5253) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5256), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5257) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5259), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5260) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5262), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5264) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5266), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5268) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5270), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5271) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5273), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5274) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5276), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5279), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5281) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5283), new DateTime(2022, 12, 10, 15, 58, 3, 494, DateTimeKind.Local).AddTicks(5284) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
