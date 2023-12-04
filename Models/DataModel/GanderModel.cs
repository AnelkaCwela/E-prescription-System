using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class GanderModel
    {
        [Key]
        public int GanderId { get; set; } 
        [Required]
        [Display(Name ="Gander Name")]
        public string? GanderName { get; set; }
    }
}
