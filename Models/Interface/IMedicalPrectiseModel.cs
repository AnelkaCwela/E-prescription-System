using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IMedicalPrectiseModel
    {
        MedicalPrectiseModel Add(MedicalPrectiseModel model);
        MedicalPrectiseModel Remove(MedicalPrectiseModel model);
        List<MedicalPrectiseModel> GetAll();
        MedicalPrectiseModel GetById(int id);
    }
}
