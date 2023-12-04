using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class PatientMedicationModel
    {
        [Key]
        public int PatientMedicationId { get; set; }
        public bool IsActive { get; set; }
        public int MedicationId { get; set; }
        [ForeignKey("MedicationId")]
        public MedicationModel? Medication { get; set; }
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public PatientUserModel? patientUserModel { get; set; }
    }
}
