using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2022.Migrations
{
    public partial class ret : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MedicationDescription",
                table: "MedicationTbl");

            migrationBuilder.AlterColumn<string>(
                name: "MedicationName",
                table: "MedicationTbl",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Schedule",
                table: "MedicationTbl",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Schedule",
                table: "MedicationTbl");

            migrationBuilder.AlterColumn<string>(
                name: "MedicationName",
                table: "MedicationTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "MedicationDescription",
                table: "MedicationTbl",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
