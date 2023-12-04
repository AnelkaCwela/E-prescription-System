using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Project2022.Models.DataModel
{
    public class DoctorAlertModel
    {
        [Key]
        public int DoctorAlertId { get; set; }
        [Display(Name ="Reason for ignoring alert")]
        public string? DescrReasonIgnoring { get; set; }
        [Required]
        public int MedicationId { get; set; }
        [ForeignKey("MedicationId")]
        public MedicationModel? Medication { get; set; }
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public DoctorUserModel? doctorUserModel { get; set; }
        public DateTime? DispenceDate { get; set; }
    }
}
