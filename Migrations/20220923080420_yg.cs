using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project2022.Migrations
{
    public partial class yg : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActiveIngredientTbl",
                columns: table => new
                {
                    ActiveIngredientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActiveIngredientName = table.Column<string>(nullable: false),
                    ActiveIngredientStrength = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActiveIngredientTbl", x => x.ActiveIngredientId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    RoleDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    RegTime = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DiagonosisTbl",
                columns: table => new
                {
                    DiagonosisId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiagonosisDescription = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiagonosisTbl", x => x.DiagonosisId);
                });

            migrationBuilder.CreateTable(
                name: "DoctorSpecializationTbl",
                columns: table => new
                {
                    DoctorSpecializationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DoctorSpecializationName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorSpecializationTbl", x => x.DoctorSpecializationId);
                });

            migrationBuilder.CreateTable(
                name: "DosageFormTbl",
                columns: table => new
                {
                    DosageFormId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DosageFormName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DosageFormTbl", x => x.DosageFormId);
                });

            migrationBuilder.CreateTable(
                name: "GanderTbl",
                columns: table => new
                {
                    GanderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GanderName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GanderTbl", x => x.GanderId);
                });

            migrationBuilder.CreateTable(
                name: "MedicationCategoryTbl",
                columns: table => new
                {
                    MedicationCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationCategoryName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationCategoryTbl", x => x.MedicationCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "PharmacTbl",
                columns: table => new
                {
                    PharmacId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PharmacName = table.Column<string>(nullable: false),
                    TellNumber = table.Column<string>(maxLength: 11, nullable: false),
                    FaxNumber = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    PharmacRegNumber = table.Column<string>(nullable: true),
                    Statuse = table.Column<bool>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: false),
                    SuburbName = table.Column<string>(nullable: false),
                    PostCode = table.Column<string>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacTbl", x => x.PharmacId);
                });

            migrationBuilder.CreateTable(
                name: "ProvinceTbl",
                columns: table => new
                {
                    ProvinceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProvinceName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProvinceTbl", x => x.ProvinceId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AdminUserTbl",
                columns: table => new
                {
                    AdminId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Statuse = table.Column<bool>(nullable: true),
                    CellNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminUserTbl", x => x.AdminId);
                    table.ForeignKey(
                        name: "FK_AdminUserTbl_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    RoleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientUserTbl",
                columns: table => new
                {
                    PatientId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Statuse = table.Column<bool>(nullable: false),
                    HasVistedDoctor = table.Column<bool>(nullable: false),
                    CellNumber = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: false),
                    SuburbName = table.Column<string>(nullable: false),
                    PostCode = table.Column<string>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    GanderId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientUserTbl", x => x.PatientId);
                    table.ForeignKey(
                        name: "FK_PatientUserTbl_GanderTbl_GanderId",
                        column: x => x.GanderId,
                        principalTable: "GanderTbl",
                        principalColumn: "GanderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicationTbl",
                columns: table => new
                {
                    MedicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicationName = table.Column<string>(nullable: true),
                    MedicationDescription = table.Column<string>(nullable: true),
                    Uses = table.Column<string>(nullable: false),
                    Direction = table.Column<string>(nullable: false),
                    Warnings = table.Column<string>(nullable: false),
                    DosageFormId = table.Column<int>(nullable: false),
                    MedicationCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationTbl", x => x.MedicationId);
                    table.ForeignKey(
                        name: "FK_MedicationTbl_DosageFormTbl_DosageFormId",
                        column: x => x.DosageFormId,
                        principalTable: "DosageFormTbl",
                        principalColumn: "DosageFormId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicationTbl_MedicationCategoryTbl_MedicationCategoryId",
                        column: x => x.MedicationCategoryId,
                        principalTable: "MedicationCategoryTbl",
                        principalColumn: "MedicationCategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PharmacistUserTbl",
                columns: table => new
                {
                    PharmacistId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    PharmacistRegNumber = table.Column<string>(nullable: false),
                    Statuse = table.Column<bool>(nullable: false),
                    CellNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    PharmacId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacistUserTbl", x => x.PharmacistId);
                    table.ForeignKey(
                        name: "FK_PharmacistUserTbl_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PharmacistUserTbl_PharmacTbl_PharmacId",
                        column: x => x.PharmacId,
                        principalTable: "PharmacTbl",
                        principalColumn: "PharmacId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(nullable: false),
                    ProvinceId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_CityTbl_ProvinceTbl_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "ProvinceTbl",
                        principalColumn: "ProvinceId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllergyTbl",
                columns: table => new
                {
                    AllergyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActiveIngredientId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllergyTbl", x => x.AllergyId);
                    table.ForeignKey(
                        name: "FK_AllergyTbl_ActiveIngredientTbl_ActiveIngredientId",
                        column: x => x.ActiveIngredientId,
                        principalTable: "ActiveIngredientTbl",
                        principalColumn: "ActiveIngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AllergyTbl_PatientUserTbl_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientUserTbl",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalHistoryTbl",
                columns: table => new
                {
                    MedicalHistoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsDiagnosed = table.Column<bool>(nullable: false),
                    DiagonosisId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalHistoryTbl", x => x.MedicalHistoryId);
                    table.ForeignKey(
                        name: "FK_MedicalHistoryTbl_DiagonosisTbl_DiagonosisId",
                        column: x => x.DiagonosisId,
                        principalTable: "DiagonosisTbl",
                        principalColumn: "DiagonosisId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicalHistoryTbl_PatientUserTbl_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientUserTbl",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicationActiveIngredienceTbl",
                columns: table => new
                {
                    MedicationActiveIngredienceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActiveIngredientId = table.Column<int>(nullable: false),
                    MedicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicationActiveIngredienceTbl", x => x.MedicationActiveIngredienceId);
                    table.ForeignKey(
                        name: "FK_MedicationActiveIngredienceTbl_ActiveIngredientTbl_ActiveIngredientId",
                        column: x => x.ActiveIngredientId,
                        principalTable: "ActiveIngredientTbl",
                        principalColumn: "ActiveIngredientId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MedicationActiveIngredienceTbl_MedicationTbl_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "MedicationTbl",
                        principalColumn: "MedicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PatientMedicationTbl",
                columns: table => new
                {
                    PatientMedicationId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsActive = table.Column<bool>(nullable: false),
                    MedicationId = table.Column<int>(nullable: false),
                    PatientId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PatientMedicationTbl", x => x.PatientMedicationId);
                    table.ForeignKey(
                        name: "FK_PatientMedicationTbl_MedicationTbl_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "MedicationTbl",
                        principalColumn: "MedicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PatientMedicationTbl_PatientUserTbl_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientUserTbl",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MedicalPrectiseTbl",
                columns: table => new
                {
                    MedicalPrectiseId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MedicalPrectiseName = table.Column<string>(nullable: false),
                    TellNumber = table.Column<string>(nullable: false),
                    FaxNumber = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    MedicalPrectiseRegNumber = table.Column<string>(nullable: false),
                    Statuse = table.Column<bool>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: false),
                    SuburbName = table.Column<string>(nullable: false),
                    PostCode = table.Column<string>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MedicalPrectiseTbl", x => x.MedicalPrectiseId);
                    table.ForeignKey(
                        name: "FK_MedicalPrectiseTbl_CityTbl_CityId",
                        column: x => x.CityId,
                        principalTable: "CityTbl",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorUserTbl",
                columns: table => new
                {
                    DoctorId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: false),
                    LastName = table.Column<string>(nullable: false),
                    Statuse = table.Column<bool>(nullable: true),
                    HelthCouncilRegNumber = table.Column<string>(nullable: false),
                    CellNumber = table.Column<string>(maxLength: 11, nullable: false),
                    Email = table.Column<string>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    DoctorSpecializationId = table.Column<int>(nullable: false),
                    MedicalPrectiseId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorUserTbl", x => x.DoctorId);
                    table.ForeignKey(
                        name: "FK_DoctorUserTbl_DoctorSpecializationTbl_DoctorSpecializationId",
                        column: x => x.DoctorSpecializationId,
                        principalTable: "DoctorSpecializationTbl",
                        principalColumn: "DoctorSpecializationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorUserTbl_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorUserTbl_MedicalPrectiseTbl_MedicalPrectiseId",
                        column: x => x.MedicalPrectiseId,
                        principalTable: "MedicalPrectiseTbl",
                        principalColumn: "MedicalPrectiseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorAlertTbl",
                columns: table => new
                {
                    DoctorAlertId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrReasonIgnoring = table.Column<string>(nullable: true),
                    MedicationId = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    DispenceDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorAlertTbl", x => x.DoctorAlertId);
                    table.ForeignKey(
                        name: "FK_DoctorAlertTbl_DoctorUserTbl_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "DoctorUserTbl",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorAlertTbl_MedicationTbl_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "MedicationTbl",
                        principalColumn: "MedicationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionTbl",
                columns: table => new
                {
                    PrescriptionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientId = table.Column<int>(nullable: false),
                    DoctorId = table.Column<int>(nullable: false),
                    PrescriptionDate = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    Repeat = table.Column<int>(nullable: false),
                    Instruction = table.Column<string>(nullable: true),
                    MedicationId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionTbl", x => x.PrescriptionId);
                    table.ForeignKey(
                        name: "FK_PrescriptionTbl_DoctorUserTbl_DoctorId",
                        column: x => x.DoctorId,
                        principalTable: "DoctorUserTbl",
                        principalColumn: "DoctorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionTbl_MedicationTbl_MedicationId",
                        column: x => x.MedicationId,
                        principalTable: "MedicationTbl",
                        principalColumn: "MedicationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionTbl_PatientUserTbl_PatientId",
                        column: x => x.PatientId,
                        principalTable: "PatientUserTbl",
                        principalColumn: "PatientId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DispenceModelTbl",
                columns: table => new
                {
                    DispenceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PharmacId = table.Column<int>(nullable: false),
                    PrescriptionId = table.Column<int>(nullable: false),
                    DispenceDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DispenceModelTbl", x => x.DispenceId);
                    table.ForeignKey(
                        name: "FK_DispenceModelTbl_PharmacTbl_PharmacId",
                        column: x => x.PharmacId,
                        principalTable: "PharmacTbl",
                        principalColumn: "PharmacId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DispenceModelTbl_PrescriptionTbl_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "PrescriptionTbl",
                        principalColumn: "PrescriptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PharmacyAlertTbl",
                columns: table => new
                {
                    PharmacyAlertId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DescrReasonIgnoring = table.Column<string>(nullable: true),
                    PrescriptionId = table.Column<int>(nullable: false),
                    PharmacId = table.Column<int>(nullable: false),
                    AlertDate = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PharmacyAlertTbl", x => x.PharmacyAlertId);
                    table.ForeignKey(
                        name: "FK_PharmacyAlertTbl_PharmacTbl_PharmacId",
                        column: x => x.PharmacId,
                        principalTable: "PharmacTbl",
                        principalColumn: "PharmacId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PharmacyAlertTbl_PrescriptionTbl_PrescriptionId",
                        column: x => x.PrescriptionId,
                        principalTable: "PrescriptionTbl",
                        principalColumn: "PrescriptionId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AdminUserTbl_Id",
                table: "AdminUserTbl",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AllergyTbl_ActiveIngredientId",
                table: "AllergyTbl",
                column: "ActiveIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_AllergyTbl_PatientId",
                table: "AllergyTbl",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_ProvinceId",
                table: "CityTbl",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_DispenceModelTbl_PharmacId",
                table: "DispenceModelTbl",
                column: "PharmacId");

            migrationBuilder.CreateIndex(
                name: "IX_DispenceModelTbl_PrescriptionId",
                table: "DispenceModelTbl",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAlertTbl_DoctorId",
                table: "DoctorAlertTbl",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorAlertTbl_MedicationId",
                table: "DoctorAlertTbl",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorUserTbl_DoctorSpecializationId",
                table: "DoctorUserTbl",
                column: "DoctorSpecializationId");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorUserTbl_Id",
                table: "DoctorUserTbl",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_DoctorUserTbl_MedicalPrectiseId",
                table: "DoctorUserTbl",
                column: "MedicalPrectiseId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistoryTbl_DiagonosisId",
                table: "MedicalHistoryTbl",
                column: "DiagonosisId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalHistoryTbl_PatientId",
                table: "MedicalHistoryTbl",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicalPrectiseTbl_CityId",
                table: "MedicalPrectiseTbl",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationActiveIngredienceTbl_ActiveIngredientId",
                table: "MedicationActiveIngredienceTbl",
                column: "ActiveIngredientId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationActiveIngredienceTbl_MedicationId",
                table: "MedicationActiveIngredienceTbl",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationTbl_DosageFormId",
                table: "MedicationTbl",
                column: "DosageFormId");

            migrationBuilder.CreateIndex(
                name: "IX_MedicationTbl_MedicationCategoryId",
                table: "MedicationTbl",
                column: "MedicationCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicationTbl_MedicationId",
                table: "PatientMedicationTbl",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientMedicationTbl_PatientId",
                table: "PatientMedicationTbl",
                column: "PatientId");

            migrationBuilder.CreateIndex(
                name: "IX_PatientUserTbl_GanderId",
                table: "PatientUserTbl",
                column: "GanderId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacistUserTbl_Id",
                table: "PharmacistUserTbl",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacistUserTbl_PharmacId",
                table: "PharmacistUserTbl",
                column: "PharmacId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyAlertTbl_PharmacId",
                table: "PharmacyAlertTbl",
                column: "PharmacId");

            migrationBuilder.CreateIndex(
                name: "IX_PharmacyAlertTbl_PrescriptionId",
                table: "PharmacyAlertTbl",
                column: "PrescriptionId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionTbl_DoctorId",
                table: "PrescriptionTbl",
                column: "DoctorId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionTbl_MedicationId",
                table: "PrescriptionTbl",
                column: "MedicationId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionTbl_PatientId",
                table: "PrescriptionTbl",
                column: "PatientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AdminUserTbl");

            migrationBuilder.DropTable(
                name: "AllergyTbl");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DispenceModelTbl");

            migrationBuilder.DropTable(
                name: "DoctorAlertTbl");

            migrationBuilder.DropTable(
                name: "MedicalHistoryTbl");

            migrationBuilder.DropTable(
                name: "MedicationActiveIngredienceTbl");

            migrationBuilder.DropTable(
                name: "PatientMedicationTbl");

            migrationBuilder.DropTable(
                name: "PharmacistUserTbl");

            migrationBuilder.DropTable(
                name: "PharmacyAlertTbl");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "DiagonosisTbl");

            migrationBuilder.DropTable(
                name: "ActiveIngredientTbl");

            migrationBuilder.DropTable(
                name: "PharmacTbl");

            migrationBuilder.DropTable(
                name: "PrescriptionTbl");

            migrationBuilder.DropTable(
                name: "DoctorUserTbl");

            migrationBuilder.DropTable(
                name: "MedicationTbl");

            migrationBuilder.DropTable(
                name: "PatientUserTbl");

            migrationBuilder.DropTable(
                name: "DoctorSpecializationTbl");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "MedicalPrectiseTbl");

            migrationBuilder.DropTable(
                name: "DosageFormTbl");

            migrationBuilder.DropTable(
                name: "MedicationCategoryTbl");

            migrationBuilder.DropTable(
                name: "GanderTbl");

            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "ProvinceTbl");
        }
    }
}
