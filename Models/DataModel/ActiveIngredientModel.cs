using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class ActiveIngredientModel
    {
        [Key]
        public int ActiveIngredientId { get; set; }
        [Display(Name = "Active Ingredient")]
        [Required]
        public string? ActiveIngredientName { get; set; }
        


    }
}
