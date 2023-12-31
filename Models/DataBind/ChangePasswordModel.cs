﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project2022.Models.DataBind
{
    public class ChangePasswordModel
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Current Password")]
        [Required]
        [DataType(DataType.Password)]
        public string? CurrentPassord { get; set; }


        [Display(Name = "New Password")]
        [Required]
        [DataType(DataType.Password)]
        public string? NewPassword { get; set; }



        [Display(Name = "Cornfirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("NewPassword")]
        public string? ConfirmPassword { get; set; }
    }
}
