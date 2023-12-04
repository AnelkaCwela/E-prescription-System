﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataModel
{
    public class MedicalPrectiseModel
    {
        [Key]
        public int MedicalPrectiseId { get; set; }
        [Required]
        [Display(Name = "Medical Prectise Name")]
        public string? MedicalPrectiseName { get; set; }
        [Required]
        [Display(Name = "Tell Number")]
        public string? TellNumber { get; set; }
        [Required]
        [Display(Name = "Fax Number")]
        public string? FaxNumber { get; set; }
        [Required]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Display(Name = "Medical Prectise Registration Number")]    
        public string? MedicalPrectiseRegNumber { get; set; }
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
        [ForeignKey("CityId")]
        public CityModel? CityModel { get; set; }
    }
}
