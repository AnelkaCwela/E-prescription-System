using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2022.Migrations
{
    public partial class ase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveIngredientStrength",
                table: "ActiveIngredientTbl");

            migrationBuilder.AddColumn<string>(
                name: "ActiveIngredientStrength",
                table: "MedicationActiveIngredienceTbl",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "MedicalPrectiseRegNumber",
                table: "MedicalPrectiseTbl",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ActiveIngredientStrength",
                table: "MedicationActiveIngredienceTbl");

            migrationBuilder.AlterColumn<string>(
                name: "MedicalPrectiseRegNumber",
                table: "MedicalPrectiseTbl",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ActiveIngredientStrength",
                table: "ActiveIngredientTbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
