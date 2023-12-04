using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Threading.Tasks;
using Project2022.Models.DataModel;
namespace Project2022.Models
{
    public class DBCONTEX : IdentityDbContext<UserModel, IdentityRoleModel, int>
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public DBCONTEX(DbContextOptions<DBCONTEX> options) : base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        { }
        public DbSet<ProvinceModel> ProvinceTbl { get; set; }
        public DbSet<CurrentVistModel> CurrentVistTbl { get; set; }
        public DbSet<PrescriptionModel> PrescriptionTbl { get; set; }
        public DbSet<PharmacModel> PharmacTbl { get; set; }
        public DbSet<PharmacistUserModel> PharmacistUserTbl { get; set; }
        public DbSet<PatientUserModel> PatientUserTbl { get; set; }
        public DbSet<PatientMedicationModel> PatientMedicationTbl { get; set; }
        public DbSet<MedicationModel> MedicationTbl { get; set; }
        public DbSet<MedicationCategoryModel> MedicationCategoryTbl { get; set; }
        public DbSet<MedicalPrectiseModel> MedicalPrectiseTbl { get; set; }
        public DbSet<DosageFormModel> DosageFormTbl { get; set; }
        public DbSet<DoctorUserModel> DoctorUserTbl { get; set; }
        public DbSet<DoctorSpecializationModel> DoctorSpecializationTbl { get; set; }
        public DbSet<DispenceModel> DispenceModelTbl { get; set; }
        public DbSet<DiagonosisModel> DiagonosisTbl { get; set; }
        public DbSet<CityModel> CityTbl { get; set; }
        public DbSet<AdminUserModel> AdminUserTbl { get; set; }
        public DbSet<ActiveIngredientModel> ActiveIngredientTbl { get; set; }
        public DbSet<AllergyModel> AllergyTbl { get; set; }
        public DbSet<GanderModel> GanderTbl { get; set; }
        public DbSet<PharmacyAlertModel> PharmacyAlertTbl { get; set; }
        public DbSet<DoctorAlertModel> DoctorAlertTbl { get; set; }
        public DbSet<MedicalHistoryModel> MedicalHistoryTbl { get; set; }
        public DbSet<MedicationActiveIngredienceModel> MedicationActiveIngredienceTbl { get; set; }
 
    }
}
