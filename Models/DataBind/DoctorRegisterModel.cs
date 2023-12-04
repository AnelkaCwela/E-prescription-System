using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Project2022.Models.DataModel;
using Microsoft.AspNetCore.Identity;

namespace Project2022.Models.DataBind
{
    public class DoctorRegisterModel
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
        public string? CellNumber { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
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
