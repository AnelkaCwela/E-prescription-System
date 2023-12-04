using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IPatientMedicationModel
    {
        PatientMedicationModel Add(PatientMedicationModel model);
        PatientMedicationModel Remove(PatientMedicationModel model);
        List<PatientMedicationModel> GetAll();
        PatientMedicationModel GetById(int id);
    }
}
