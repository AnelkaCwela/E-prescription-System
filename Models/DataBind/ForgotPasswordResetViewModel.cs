using System.ComponentModel.DataAnnotations;
namespace Project2022.Models.DataBind
{
    public class ForgotPasswordResetViewModel
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Password")]
        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [Display(Name = "Confirm Password")]
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")]

        public string? ConfirmPassword { get; set; }
        public string? token { get; set; }
        public string? Email { get; set; }
    }
}
