using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class _9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3016), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3046) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3049), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3051) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3052), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3054) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3056), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3057) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3059), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3060) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3063), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3064) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3066), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3068) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3069), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3071) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3073), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3076), new DateTime(2022, 12, 10, 15, 58, 36, 899, DateTimeKind.Local).AddTicks(3077) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
