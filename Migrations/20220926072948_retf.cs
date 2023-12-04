using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2022.Migrations
{
    public partial class retf : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdendityNumber",
                table: "PatientUserTbl",
                maxLength: 13,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdendityNumber",
                table: "PatientUserTbl");
        }
    }
}
