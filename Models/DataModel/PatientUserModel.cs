using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class PatientUserModel
    {
        [Key]
        public int PatientId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string? LastName { get; set; }
        [Required]
        [Display(Name = "Satuse")]
        public bool? Statuse { get; set; }
        [Required]
        [Display(Name = "Visited Doctor")]
        public bool? HasVistedDoctor { get; set; }
        [Required]
        [MinLength(10), MaxLength(11)]
        [Display(Name = "Cell Number")]
        public string? CellNumber { get; set; }
        [Required]
        [MinLength(13), MaxLength(13)]
        [Display(Name = "Idendity Number")]
        public string? IdendityNumber { get; set; }
        [Required]
        [Display(Name = "Email Address")]
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

        [Required]        
        public int Id { get; set; }
        [Required]
     
        public int GanderId { get; set; }
        [ForeignKey("GanderId")]
        public GanderModel? GanderModel { get; set; }
    }
}
