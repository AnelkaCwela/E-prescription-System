using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class AllergyModel
    {
        [Key]
        public int AllergyId { get; set; }
        public int ActiveIngredientId { get; set; }
        [ForeignKey("ActiveIngredientId")]
        public ActiveIngredientModel? ActiveIngredientModel { get; set; }
        public int PatientId { get; set; }
        [ForeignKey("PatientId")]
        public PatientUserModel? patientUserModel { get; set; }
    }
}
