using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project2022.Models.DataBind
{
    public class RegisterUserModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        [Required]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Required]
        [MaxLength(13)]
        [MinLength(12)]
        [Display(Name = "Idendity Number")]
        [Remote(action: "IdentityNoIsInUsE", controller: "Account")]
        public string? IdendityNumber { get; set; }
        [Required]

        [Display(Name = "Cell Number")]
        public string? CellNumber { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        [Remote(action: "EmailIsInUsE", controller: "Account")]
        [Required]
        public string? Email { get; set; }
        [Display(Name = "Gander")]
        [Required]
        public int GanderId { get; set; }
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
        // [Required]
        [Display(Name = "City")]
        public int CityId { get; set; }

        [Required]
        [Display(Name = "Province")]
        public int ProvinceId { get; set; }

        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]

        public string ConfirmPassword { get; set; }
    }
}

