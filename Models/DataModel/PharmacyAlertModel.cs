using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System;

namespace Project2022.Models.DataModel
{
    public class PharmacyAlertModel
    {
        [Key]
        public int PharmacyAlertId { get; set; }
        [Display(Name = "Reason for ignoring alert")]
        public string? DescrReasonIgnoring { get; set; }
        [Required]
        public int PrescriptionId { get; set; }
        [ForeignKey("PrescriptionId")]
        public PrescriptionModel? PrescriptionModel { get; set; }
        public int PharmacId { get; set; }
        [ForeignKey("PharmacId")]
        public PharmacModel? PharmacModel { get; set; }
        public DateTime? AlertDate { get; set; }
    }
}

