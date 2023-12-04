using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class MedicationCategoryModel
    {
        [Key]
        public int MedicationCategoryId { get; set; } 
        [Required]  
        [Display(Name = "Medication Category")]
        public string? MedicationCategoryName { get; set; }
    }
}
