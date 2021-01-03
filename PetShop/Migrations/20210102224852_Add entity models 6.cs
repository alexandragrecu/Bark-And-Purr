using Microsoft.EntityFrameworkCore.Migrations;

namespace PetShop.Migrations
{
    public partial class Addentitymodels6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Customers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Customers");
        }
    }
}
