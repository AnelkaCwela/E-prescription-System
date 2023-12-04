using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project2022.Models.DataModel
{
    public class MedicationActiveIngredienceModel
    {
        [Key]
        public int MedicationActiveIngredienceId { get; set; }
        [Display(Name = "Active Strength")]
        [Required]
        public string? ActiveIngredientStrength { get; set; }
        public int ActiveIngredientId { get; set; }
        [ForeignKey("ActiveIngredientId")]
        public ActiveIngredientModel? ActiveIngredientModel { get; set; }
        public int MedicationId { get; set; }
        [ForeignKey("MedicationId")]
        public MedicationModel? MedicationModel { get; set; }

    }
}
