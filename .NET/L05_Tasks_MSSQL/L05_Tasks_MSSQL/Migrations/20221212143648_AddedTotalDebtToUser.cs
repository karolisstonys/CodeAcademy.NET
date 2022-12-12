using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddedTotalDebtToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalDebt",
                table: "Users",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8163), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8176), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8178) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8173), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8156), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8157) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8109), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8147) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8166), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8168) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8149), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8151) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8159), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8160) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8169), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8171) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8152), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8154) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8179), new DateTime(2022, 12, 12, 16, 36, 47, 812, DateTimeKind.Local).AddTicks(8181) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalDebt",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4147), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4148) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4160), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4161) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4156), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4140), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4142) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4093), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4131) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4150), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4151) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4133), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4135) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4143), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4145) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4153), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4155) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4137), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4163), new DateTime(2022, 12, 12, 12, 39, 44, 97, DateTimeKind.Local).AddTicks(4164) });
        }
    }
}
