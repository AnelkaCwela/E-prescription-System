using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class PharmacistUserModel
    {
        [Key]
        public int PharmacistId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Required]
        [Display(Name = "Pharmacist Reg No")]
        public string? PharmacistRegNumber { get; set; }
        [Required]
        [Display(Name = "Satuse")]
        public bool? Statuse { get; set; }
        [Required]
        [Display(Name = "Cell Number")]
        public string? CellNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
           [Required]
        public int Id { get; set; }
        [ForeignKey("Id")]
        public UserModel? UserModel { get; set; }
        [Required]
        public int PharmacId { get; set; }
        [ForeignKey("PharmacId")]
        public PharmacModel? PharmacModel { get; set; }
    }
}
