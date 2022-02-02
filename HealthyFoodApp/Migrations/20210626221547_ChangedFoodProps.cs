using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyFoodApp.Migrations
{
    public partial class ChangedFoodProps : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "Calcium",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Calories",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Carbohydrates",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Foods",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DietaryFiber",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Iron",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Potassium",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Protein",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Sodium",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sugar",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TotalFat",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminD",
                table: "Foods",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Calcium",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Calories",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Carbohydrates",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DietaryFiber",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Iron",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Potassium",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Protein",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Sodium",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Sugar",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "TotalFat",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "VitaminD",
                table: "Foods");
        }
    }
}
