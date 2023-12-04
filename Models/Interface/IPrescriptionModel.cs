using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IPrescriptionModel
    {
        PrescriptionModel Add(PrescriptionModel model);
        PrescriptionModel Remove(PrescriptionModel model);
        List<PrescriptionModel> GetAll();
        PrescriptionModel GetById(int id);
        List<PrescriptionModel> GetAllByPatientId(int PatientId);
    }
}
