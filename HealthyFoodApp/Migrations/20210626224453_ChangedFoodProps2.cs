using Microsoft.EntityFrameworkCore.Migrations;

namespace HealthyFoodApp.Migrations
{
    public partial class ChangedFoodProps2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TotalFat",
                table: "Foods",
                newName: "Zinc");

            migrationBuilder.RenameColumn(
                name: "DietaryFiber",
                table: "Foods",
                newName: "Water");

            migrationBuilder.RenameColumn(
                name: "Carbohydrates",
                table: "Foods",
                newName: "VitaminARae");

            migrationBuilder.AlterColumn<float>(
                name: "Sugar",
                table: "Foods",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Sodium",
                table: "Foods",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Potassium",
                table: "Foods",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Calcium",
                table: "Foods",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Alcohol",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "ButanoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Caffeine",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Carbohydrate",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaroteneAlpha",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CaroteneBeta",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cholesterol",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Choline",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Copper",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Cryptoxanthin",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DecanoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DocosahexaenoicN3Acid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DocosapentaenoicN3acid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DocosenoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "DodecanoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "EicosapentaenoicN3Acid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "EicosatetraenoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "EicosenoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Fat",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Fiber",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FolateDFE",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FolateFood",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FolicAcid",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "HexadecanoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "HexadecenoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "HexanoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LuteinZeaxanthin",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Lycopene",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Magnesium",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "MonounsaturatedFattyAcids",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Niacin",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "OctadecadienoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "OctadecanoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "OctadecatetraenoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "OctadecatrienoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "OctadecenoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "OctanoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Phosphorus",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "PolyunsaturatedFattyAcids",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Retinol",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Riboflavin",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "SaturatedFattyAcids",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Selenium",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TetradecanoicAcid",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Theobromine",
                table: "Foods",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Thiamin",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "TocopherolAlpha",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminB12",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminB12Added",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminC",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminE",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminEAdded",
                table: "Foods",
                type: "real",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "VitaminK",
                table: "Foods",
                type: "real",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alcohol",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "ButanoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Caffeine",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Carbohydrate",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "CaroteneAlpha",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "CaroteneBeta",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Cholesterol",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Choline",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Copper",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Cryptoxanthin",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DecanoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DocosahexaenoicN3Acid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DocosapentaenoicN3acid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DocosenoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "DodecanoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "EicosapentaenoicN3Acid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "EicosatetraenoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "EicosenoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Fat",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Fiber",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "FolateDFE",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "FolateFood",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "FolicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "HexadecanoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "HexadecenoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "HexanoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "LuteinZeaxanthin",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Lycopene",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Magnesium",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "MonounsaturatedFattyAcids",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Niacin",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "OctadecadienoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "OctadecanoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "OctadecatetraenoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "OctadecatrienoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "OctadecenoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "OctanoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Phosphorus",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "PolyunsaturatedFattyAcids",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Retinol",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Riboflavin",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "SaturatedFattyAcids",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Selenium",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "TetradecanoicAcid",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Theobromine",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "Thiamin",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "TocopherolAlpha",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "VitaminB12",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "VitaminB12Added",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "VitaminC",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "VitaminE",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "VitaminEAdded",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "VitaminK",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "Zinc",
                table: "Foods",
                newName: "TotalFat");

            migrationBuilder.RenameColumn(
                name: "Water",
                table: "Foods",
                newName: "DietaryFiber");

            migrationBuilder.RenameColumn(
                name: "VitaminARae",
                table: "Foods",
                newName: "Carbohydrates");

            migrationBuilder.AlterColumn<int>(
                name: "Sugar",
                table: "Foods",
                type: "int",
                nullable: true,
                oldClrType: typeof(float),
                oldType: "real",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Sodium",
                table: "Foods",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Potassium",
                table: "Foods",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<float>(
                name: "Calcium",
                table: "Foods",
                type: "real",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);
        }
    }
}
