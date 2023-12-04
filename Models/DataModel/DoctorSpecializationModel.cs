using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class DoctorSpecializationModel
    {
        [Key]
        public int DoctorSpecializationId { get; set; }
        [Required]
        [Display(Name = " Doctor Specialization Name")]
        public string? DoctorSpecializationName { get; set; }
    }
}
