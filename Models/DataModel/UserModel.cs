using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System;
namespace Project2022.Models.DataModel
{
    public class UserModel : IdentityUser<int>
    {
        public DateTime RegTime { get; set; }   

    }
}
