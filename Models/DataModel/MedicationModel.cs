using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project2022.Models.DataModel
{
    public class MedicationModel
    {
        [Key]
        public int MedicationId { get; set; }
        [Required]
        [Display(Name = "Medication Name")]
        public string? MedicationName { get; set; }
        [Display(Name = "Schedule")]
        [Required]
        public int Schedule { get; set; }
        [Display(Name = "Uses")]
        [Required]
        public string? Uses { get; set; }
        [Display(Name = "Direction")]
        [Required]
        public string? Direction { get; set; }
        [Display(Name = "Warnings")]
        [Required]
        public string? Warnings { get; set; }
        [Required]
        public int DosageFormId { get; set; }
        [ForeignKey("DosageFormId")]
        public DosageFormModel? dosageFormModel { get; set; }
        [Required]
        public int MedicationCategoryId { get; set; }
        [ForeignKey("MedicationCategoryId")]
        public MedicationCategoryModel? MedicationCategoryModel { get; set; }

    }
}
