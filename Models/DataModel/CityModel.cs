using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project2022.Models.DataModel
{
    public class CityModel
    {
        [Key]
        public int CityId { get; set; }
        [Required]
        [Display(Name = "City Name")]
        public string? CityName { get; set; }
        [Required]
        public int? ProvinceId { get; set; }
        [ForeignKey("ProvinceId")]
        public ProvinceModel? provinceModel { get; set; }
    }
}
