using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyFoodApp.Migrations
{
    public partial class AddedVitaminB6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "VitaminB6",
                table: "Foods",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VitaminB6",
                table: "Foods");
        }
    }
}
