using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class addedPointsAndLastLoginToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "LastLogin",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<long>(
                name: "Points",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9852), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9854) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9867), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9868) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9863), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9865) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9845), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9847) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9781), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9830) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9856), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9857) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9837), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9839) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9849), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9860), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9841), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9842) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9870), new DateTime(2022, 12, 21, 20, 39, 54, 299, DateTimeKind.Local).AddTicks(9872) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LastLogin",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Points",
                table: "Users");

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
    }
}
