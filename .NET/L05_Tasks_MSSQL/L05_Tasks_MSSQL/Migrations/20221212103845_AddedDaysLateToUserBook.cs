using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddedDaysLateToUserBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DaysLate",
                table: "UserBooks",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3150), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3152) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3164), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3166) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3161), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3163) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3143), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3145) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3091), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3133) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3154), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3156) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3135), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3137) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3147), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3148) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3158), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3159) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3140), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3141) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3168), new DateTime(2022, 12, 12, 12, 38, 44, 988, DateTimeKind.Local).AddTicks(3169) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DaysLate",
                table: "UserBooks");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8131), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8132) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8144), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8145) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8140), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8124), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8126) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8080), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8115) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8134), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8136) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8117), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8119) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8128), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8137), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8139) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8120), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8122) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8147), new DateTime(2022, 12, 11, 19, 50, 35, 466, DateTimeKind.Local).AddTicks(8148) });
        }
    }
}
