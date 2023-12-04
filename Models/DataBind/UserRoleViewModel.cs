namespace Project2022.Models.DataBind
{
    public class UserRoleViewModel
    {
        public int UserId { get; set; }
        public int RoleId { get; set; }
        public string UserName { get; set; }
        public string RoleDescri { get; set; }
        public bool IsSelected
        {
            get; set;
        }
    }
}
