using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L05TasksMSSQL.Migrations
{
    /// <inheritdoc />
    public partial class addedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9933), new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9973) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9981), new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9984), new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9986) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9988), new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9990) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9992), new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9993) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9995), new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9997) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 477, DateTimeKind.Local).AddTicks(9999), new DateTime(2022, 12, 8, 20, 3, 31, 478, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 478, DateTimeKind.Local).AddTicks(2), new DateTime(2022, 12, 8, 20, 3, 31, 478, DateTimeKind.Local).AddTicks(4) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 478, DateTimeKind.Local).AddTicks(6), new DateTime(2022, 12, 8, 20, 3, 31, 478, DateTimeKind.Local).AddTicks(7) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 12, 8, 20, 3, 31, 478, DateTimeKind.Local).AddTicks(9), new DateTime(2022, 12, 8, 20, 3, 31, 478, DateTimeKind.Local).AddTicks(11) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(991), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1055) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1060), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1062) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1064), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1066) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1068), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1070) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1071), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1073) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1075), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1077) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1078), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1080) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1082), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1084) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1085), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1087) });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1089), new DateTime(2022, 11, 30, 22, 7, 0, 447, DateTimeKind.Local).AddTicks(1090) });
        }
    }
}
