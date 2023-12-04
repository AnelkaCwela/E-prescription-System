using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Project2022.Models.DataModel
{
    public class DispenceModel
    {
        [Key]
        public int DispenceId { get; set; }
        [Required]
        public int PharmacId { get; set; }
        [ForeignKey("PharmacId")]
        public PharmacModel? PharmacModel { get; set; }  
        [Required]
        public int PrescriptionId { get; set; }
        [ForeignKey("PrescriptionId")]
        public PrescriptionModel? PrescriptionModel { get; set; }
        public DateTime DispenceDate { get; set; }
    }
}
