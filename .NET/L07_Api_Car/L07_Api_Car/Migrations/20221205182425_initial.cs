using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace L07ApiCar.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Make = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Model = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Year = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlateNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    GearBox = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Fuel = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Fuel", "GearBox", "Make", "Model", "PlateNumber", "Year" },
                values: new object[,]
                {
                    { 1, "Pertol", "Manual", "Make1", "Model1", "ABC001", new DateTime(2022, 12, 5, 20, 24, 24, 955, DateTimeKind.Local).AddTicks(6168) },
                    { 2, "Diesel", "Automatic", "Make2", "Model2", "ABC002", new DateTime(2022, 12, 5, 20, 24, 24, 958, DateTimeKind.Local).AddTicks(2154) },
                    { 3, "Electric", "Manual", "Make3", "Model3", "ABC003", new DateTime(2022, 12, 5, 20, 24, 24, 958, DateTimeKind.Local).AddTicks(2179) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
