using Project2022.Models.DataModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project2022.Models.DataBind
{
    public class UserDetailModel
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string? FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string? LastName { get; set; }

        [Display(Name = "Satuse")]
        public bool? Statuse { get; set; }

        [Display(Name = "Cell Number")]
        public string? CellNumber { get; set; }

        [Display(Name = "Email Address")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
        public string? UserType { get; set; }

        //

        [Display(Name = "Helth Council Registration Number")]
        public string? HelthCouncilRegNumber { get; set; }
        //

        [Display(Name = "Pharmacist Reg No")]
        public string? PharmacistRegNumber { get; set; }
        //
        [Display(Name = "Visited Doctor")]
        public bool? HasVistedDoctor { get; set; }


    }
}
