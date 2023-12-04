using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IPatientUserModel
    {
        PatientUserModel Add(PatientUserModel model);
        PatientUserModel Remove(PatientUserModel model);
        List<PatientUserModel> GetAll();
        PatientUserModel GetById(int id);
        PatientUserModel GetByIdentityNo(string id);
        PatientUserModel Update(PatientUserModel model);
        PatientUserModel UpdateVIST(int Id);
    }
}
