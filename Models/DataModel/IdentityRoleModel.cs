using Microsoft.AspNetCore.Identity;

namespace Project2022.Models.DataModel
{
    public class IdentityRoleModel: IdentityRole<int>
    {
        public string? RoleDescription { get; set; }
    }
}
