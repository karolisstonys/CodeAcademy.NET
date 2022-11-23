using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace L04EFApplyingToAPI.Migrations
{
    /// <inheritdoc />
    public partial class addedInitialDataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Dishes",
                columns: new[] { "DishId", "Country", "CreatedDateTime", "ImagePath", "Name", "SpiceLevel", "Type" },
                values: new object[,]
                {
                    { 1, "Lithuania", new DateTime(2022, 11, 23, 21, 58, 16, 65, DateTimeKind.Local).AddTicks(4665), "", "Fried bread sticks", "Low", "Snacks" },
                    { 2, "Lithuania", new DateTime(2022, 11, 23, 21, 58, 16, 65, DateTimeKind.Local).AddTicks(4833), "", "Potatoe dumplings", "Low", "Main dish" },
                    { 3, "Lithuania", new DateTime(2022, 11, 23, 21, 58, 16, 65, DateTimeKind.Local).AddTicks(4835), "", "Kibinai", "Low", "Street food" }
                });

            migrationBuilder.InsertData(
                table: "RecipeItems",
                columns: new[] { "RecipeItemId", "Calories", "DishId", "Name" },
                values: new object[,]
                {
                    { 1, 120.0, 1, "Bread" },
                    { 2, 50.0, 1, "Cheese" },
                    { 3, 200.0, 1, "Mayo" },
                    { 4, 14.0, 1, "Garlic" },
                    { 5, 600.0, 2, "Potatoes" },
                    { 6, 420.0, 2, "Meat" },
                    { 7, 180.0, 2, "Sour cream" },
                    { 8, 120.0, 3, "Dough" },
                    { 9, 120.0, 3, "Meat" },
                    { 10, 120.0, 3, "Salt" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "RecipeItems",
                keyColumn: "RecipeItemId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Dishes",
                keyColumn: "DishId",
                keyValue: 3);
        }
    }
}
