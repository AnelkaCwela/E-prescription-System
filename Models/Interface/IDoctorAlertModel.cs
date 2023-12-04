using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IDoctorAlertModel
    {
        DoctorAlertModel Add(DoctorAlertModel model);
        DoctorAlertModel Remove(DoctorAlertModel model);
        List<DoctorAlertModel> GetAll();
        DoctorAlertModel GetById(int id);
    }
}
