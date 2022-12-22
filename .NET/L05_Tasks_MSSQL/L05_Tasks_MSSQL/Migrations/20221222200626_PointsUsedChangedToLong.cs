using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class PointsUsedChangedToLong : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "PointsUsed",
                table: "Payments",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9693), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9694) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9706), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9703), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9705) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9686), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9688) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9642), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9676) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9696), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9698) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9679), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9681) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9690), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9691) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9700), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9701) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9683), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9684) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9710), new DateTime(2022, 12, 22, 22, 6, 26, 697, DateTimeKind.Local).AddTicks(9712) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PointsUsed",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(158), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(159) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(171), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(172) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(167), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(169) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(151), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(153) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(104), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(142) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(161), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(162) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(145), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(146) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(155), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(156) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(164), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(148), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(150) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(174), new DateTime(2022, 12, 22, 17, 47, 50, 777, DateTimeKind.Local).AddTicks(176) });
        }
    }
}
