
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Project2022.Models.DataModel
{
    public class AdminUserModel
    {
        [Key]
        public int AdminId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string ? FirstName  { get; set; }
        [Display(Name = "Last Name")]
        [Required]
        public string? LastName { get; set; }
        [Display(Name = "Statuse")]
        public bool? Statuse { get; set; }
        [Display(Name = "Cell Number")]
        [Required]
        public string? CellNumber { get; set; }
        [Display(Name = "Email Address")]
        [Required]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        [Required]
   
        public int Id { get; set; }
        [ForeignKey("Id")]
        public UserModel? UserModel { get; set; }
    }
}
