using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IMedicalHistoryModel
    {
        MedicalHistoryModel Add(MedicalHistoryModel model);
        MedicalHistoryModel Remove(MedicalHistoryModel model);
        List<MedicalHistoryModel> GetAll();
        List<MedicalHistoryModel> GetAllByPatientId(int PatintId);
        MedicalHistoryModel GetById(int id);
    }
}
