using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop.Migrations
{
    public partial class Addinitialentitymodels2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "weight",
                table: "Pets",
                newName: "Weight");

            migrationBuilder.RenameColumn(
                name: "height",
                table: "Pets",
                newName: "Height");

            migrationBuilder.RenameColumn(
                name: "age",
                table: "Pets",
                newName: "Age");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Weight",
                table: "Pets",
                newName: "weight");

            migrationBuilder.RenameColumn(
                name: "Height",
                table: "Pets",
                newName: "height");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Pets",
                newName: "age");
        }
    }
}
