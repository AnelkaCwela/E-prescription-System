using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IDoctorSpecializationModel
    {
        DoctorSpecializationModel Add(DoctorSpecializationModel model);
        DoctorSpecializationModel Remove(DoctorSpecializationModel model);
        List<DoctorSpecializationModel> GetAll();
        DoctorSpecializationModel GetById(int id);
    }
}
