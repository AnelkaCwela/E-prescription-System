using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IDoctorUserModel
    {
        DoctorUserModel Add(DoctorUserModel model);
        DoctorUserModel Remove(DoctorUserModel model);
        List<DoctorUserModel> GetAll();
        DoctorUserModel GetById(int id);
        DoctorUserModel GetByEmail(string id);
        DoctorUserModel Update(DoctorUserModel model);
    }
}
