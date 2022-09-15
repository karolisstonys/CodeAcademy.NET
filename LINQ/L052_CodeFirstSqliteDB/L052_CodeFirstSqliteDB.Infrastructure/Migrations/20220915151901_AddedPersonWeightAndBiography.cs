using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L052_CodeFirstSqliteDB.Infrastructure.Migrations
{
    public partial class AddedPersonWeightAndBiography : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Biography",
                table: "Persons",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Weight",
                table: "Persons",
                type: "REAL",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biography",
                table: "Persons");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Persons");
        }
    }
}
