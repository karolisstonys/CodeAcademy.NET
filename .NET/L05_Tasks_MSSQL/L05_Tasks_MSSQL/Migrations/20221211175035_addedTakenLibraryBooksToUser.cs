using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class addedTakenLibraryBooksToUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TakenLibraryBooks",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TakenLibraryBooks",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0020198817",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6994), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6996) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0439136350",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7008), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7010) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451526929",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7005), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7006) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0451528905",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6987), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6989) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553211765",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6937), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6975) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0553213113",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6998), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0786275391",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6980), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6982) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "0847980790",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6991), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6993) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1400079985",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7001), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7003) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856134032",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6984), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(6986) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "ISBN",
                keyValue: "1856136124",
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7012), new DateTime(2022, 12, 10, 23, 46, 30, 363, DateTimeKind.Local).AddTicks(7013) });
        }
    }
}
