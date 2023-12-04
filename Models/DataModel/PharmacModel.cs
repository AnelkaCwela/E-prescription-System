using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class PharmacModel
    {
        [Key]
        public int PharmacId { get; set; }
        [Required]
        [Display(Name ="Pharmac Name")]
        public string? PharmacName { get; set; }
        [Required]
        [Display(Name = "Tell Number")]
        [MinLength(10),MaxLength(11)]
        public string? TellNumber { get; set; }
        [Required]
        [Display(Name = "Fax Number")]
        [MinLength(10), MaxLength(11)]
        public string? FaxNumber { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Display(Name = "Pharmac Registration Number")]
        public string? PharmacRegNumber { get; set; }
        [Display(Name = "Statuse")]
        public bool? Statuse { get; set; }
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
      //  [ForeignKey("CityId")]
        //public CityModel? CityModel { get; set; }
    }
}
