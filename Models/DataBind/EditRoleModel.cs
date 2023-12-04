using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Project2022.Models.DataBind
{
    public class EditRoleModel
    {
        public EditRoleModel()
        {
            Users = new List<string>();
        }
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Enter Role")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; }
        [Required(ErrorMessage = "Enter Role Decsription")]
        [Display(Name = "Role Description")]

        public string RoleDescri { get; set; }
        public List<string> Users { get; set; }
    }
}
