using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IAdminUserModel
    {
        AdminUserModel Add(AdminUserModel model);
        AdminUserModel Remove(AdminUserModel model);
        List<AdminUserModel> GetAll();
        AdminUserModel GetById(int id);
        AdminUserModel Update(AdminUserModel model);
    }
}
