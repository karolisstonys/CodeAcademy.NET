using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class AddedBooksNotReturnedInTimeToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BooksNotReturnedInTime",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BooksNotReturnedInTime",
                table: "Users");

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
    }
}
