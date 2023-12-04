using Project2022.Models.DataModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project2022.Models.DataBind
{
    public class PharmacModelRegiser
    {
        [Key]
        public int PharmacId { get; set; }
        [Required]
        [Display(Name = "Pharmac Name")]
        public string? PharmacName { get; set; }
        [Required]
        [Display(Name = "Tell Number")]
        [MinLength(10), MaxLength(11)]
        public string? TellNumber { get; set; }
        [Required]
        [Display(Name = "Fax Number")]
        [MinLength(10), MaxLength(11)]
        public string? FaxNumber { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Required]
        [Display(Name = "Address Line 1")]
        public string? AddressLine1 { get; set; }
        [Required]
        [Display(Name = "Address Line 2")]
        public string? AddressLine2 { get; set; }
        [Required]
        [Display(Name = "Suburb")]
        public string? SuburbName { get; set; }
        [Required]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Post Code")]
        public string? PostCode { get; set; }
        [Required]
        [Display(Name = "City")]
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public CityModel? CityModel { get; set; }
        [Required]
        [Display(Name = "Province")]
        public int ProvinceId { get; set; }
        [ForeignKey("ProvinceId")]
        public ProvinceModel? ProvinceModel { get; set; }
    }
}
