using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class DosageFormModel
    {
        [Key]
        public int DosageFormId { get; set; }
        [Required]
        [Display(Name = "DosageFormName")]
        public string? DosageFormName { get; set; }  
    }
}
