using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Project2022.Models.DataModel
{
    public class CurrentVistModel
    {
        [Key]
        public int CurrentVistId { get; set; }
        [Required]
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public PatientUserModel? patientUserModel { get; set; }
        [Required]
        public int DoctorId { get; set; }
        [ForeignKey("DoctorId")]
        public DoctorUserModel? doctorUserModel { get; set; }
        public DateTime VisDate { get; set; }
        
    }
}
