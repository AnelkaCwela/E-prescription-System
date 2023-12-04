using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class ProvinceModel
    {
        [Key]
        public int ProvinceId { get; set; }
        [Required]
        [Display(Name = "Province Name")]
        public string? ProvinceName { get; set; }
    }
}
