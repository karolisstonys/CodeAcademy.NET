using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace P04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Dishes",
                columns: table => new
                {
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    SpiceLevel = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: false),
                    ImagePath = table.Column<string>(type: "TEXT", nullable: false),
                    CreateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UpdateDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dishes", x => x.DishId);
                });

            migrationBuilder.CreateTable(
                name: "LocalUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Username = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    PasswordHash = table.Column<byte[]>(type: "BLOB", nullable: false),
                    PasswordSalt = table.Column<byte[]>(type: "BLOB", nullable: false),
                    Role = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LocalUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RecipeItems",
                columns: table => new
                {
                    RecipeItemId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Calories = table.Column<double>(type: "REAL", nullable: false),
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeItems", x => x.RecipeItemId);
                    table.ForeignKey(
                        name: "FK_RecipeItems_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DishOrders",
                columns: table => new
                {
                    DishOrderId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LocalUserId = table.Column<int>(type: "INTEGER", nullable: false),
                    DishId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DishOrders", x => x.DishOrderId);
                    table.ForeignKey(
                        name: "FK_DishOrders_Dishes_DishId",
                        column: x => x.DishId,
                        principalTable: "Dishes",
                        principalColumn: "DishId");
                    table.ForeignKey(
                        name: "FK_DishOrders_LocalUsers_LocalUserId",
                        column: x => x.LocalUserId,
                        principalTable: "LocalUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Country", "CreateDateTime", "ImagePath", "Name", "SpiceLevel", "Type", "UpdateDateTime" },
                values: new object[,]
                {
                    { 1, "Lithuanian", new DateTime(2022, 12, 22, 18, 54, 32, 221, DateTimeKind.Local).AddTicks(5235), "", "Fried Bread Sticks", "Mild", "Snacks", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "Lithuanian", new DateTime(2022, 12, 22, 18, 54, 32, 221, DateTimeKind.Local).AddTicks(5276), "", "Potato dumplings", "Low", "Main dish", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "Lithuanian", new DateTime(2022, 12, 22, 18, 54, 32, 221, DateTimeKind.Local).AddTicks(5279), "", "Kibinai", "Low", "Street food", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RecipeItems",
                columns: new[] { "RecipeItemId", "Calories", "DishId", "Name" },
                values: new object[,]
                {
                    { 1, 150.0, 1, "Bread" },
                    { 2, 300.0, 1, "Cheese" },
                    { 3, 300.0, 1, "Mayo" },
                    { 4, 50.0, 1, "Garlic" },
                    { 5, 400.0, 2, "Potatoes" },
                    { 6, 400.0, 2, "Meat" },
                    { 7, 300.0, 2, "Sour Cream" },
                    { 8, 300.0, 3, "Dough" },
                    { 9, 200.0, 3, "Meat" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_DishId",
                table: "DishOrders",
                column: "DishId");

            migrationBuilder.CreateIndex(
                name: "IX_DishOrders_LocalUserId",
                table: "DishOrders",
                column: "LocalUserId");

            migrationBuilder.CreateIndex(
                name: "IX_RecipeItems_DishId",
                table: "RecipeItems",
                column: "DishId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DishOrders");

            migrationBuilder.DropTable(
                name: "RecipeItems");

            migrationBuilder.DropTable(
                name: "LocalUsers");

            migrationBuilder.DropTable(
                name: "Dishes");
        }
    }
}
