using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddedPayments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    PointsUsed = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

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
    }
}
