using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project2022.Models.DataBind
{
    public class ForgotPasswordModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Email")]
        [Required]
        [DataType(DataType.EmailAddress)]

        public string? Email { get; set; }
    }
}
