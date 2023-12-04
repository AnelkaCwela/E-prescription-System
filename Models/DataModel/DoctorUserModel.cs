using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project2022.Models.DataModel
{
    public class DoctorUserModel
    {
        [Key]
        public int DoctorId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string? LastName { get; set; }
        [Display(Name = "Statuse")]
        public bool? Statuse { get; set; }
        [Required]
        [Display(Name = "Helth Council Registration Number")]
        public string? HelthCouncilRegNumber { get; set; }
        [Display(Name = "Cell Number")]
        [Required]
        [MinLength(10), MaxLength(11)]
        public string? CellNumber { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        public int Id { get; set; }
        [ForeignKey("Id")]
        public UserModel? UserModel { get; set; }
        [Required]
        [Display(Name = "Specialization")]
        public int DoctorSpecializationId { get; set; }
        [ForeignKey("DoctorSpecializationId")]
        public DoctorSpecializationModel? DoctorSpecializationModel { get; set; }
        [Required]
        [Display(Name = "Medical Prectise")]
        public int MedicalPrectiseId { get; set; }
        [ForeignKey("MedicalPrectiseId")]
        public MedicalPrectiseModel? medicalPrectiseModel { get; set; }
    }
}
