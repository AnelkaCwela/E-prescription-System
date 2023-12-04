using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2022.Migrations
{
    public partial class ad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Instruction",
                table: "PrescriptionTbl",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "CurrentVistTbl",
                columns: table => new
                {
                    CurrentVistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    VisDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CurrentVistTbl", x => x.CurrentVistId);
                    table.ForeignKey(
                        name: "FK_CurrentVistTbl_DoctorUserTbl_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "DoctorUserTbl",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CurrentVistTbl_PatientUserTbl_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientUserTbl",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CurrentVistTbl_DoctorId",
                table: "CurrentVistTbl",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_CurrentVistTbl_PatientId",
                table: "CurrentVistTbl",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CurrentVistTbl");

            migrationBuilder.AlterColumn<string>(
                name: "Instruction",
                table: "PrescriptionTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
