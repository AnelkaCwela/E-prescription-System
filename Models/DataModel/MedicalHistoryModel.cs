using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class MedicalHistoryModel
    {
        [Key]
        public int MedicalHistoryId { get; set; }  

        public bool IsDiagnosed { get; set; }
        public int DiagonosisId { get; set; }
        [ForeignKey("DiagonosisId")]
        public DiagonosisModel? DiagonosisModel { get; set; }
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public PatientUserModel? patientUserModel { get; set; }
    }
}
