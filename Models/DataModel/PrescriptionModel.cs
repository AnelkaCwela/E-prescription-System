using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Project2022.Models.DataModel
{
    public class PrescriptionModel
    { 
        [Key]
        public int PrescriptionId { get; set; }
        [Required]
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public PatientUserModel? patientUserModel { get; set; }
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public DoctorUserModel? doctorUserModel { get; set; }  
        public DateTime PrescriptionDate { get; set; }
        [Display(Name ="Quantity")]
        [Required]
        public int Quantity { get; set; }
        [Required]
        [Display(Name = "Repeat")]
        public int Repeat { get; set; }
        [Required]
        [Display(Name = "Instruction")]
        public string? Instruction { get; set; }
        [Required]
        [Display(Name = "Medication")]
        public int MedicationId { get; set; }
        [ForeignKey("MedicationId")]
        public MedicationModel? Medication { get; set; } 
    }
}
