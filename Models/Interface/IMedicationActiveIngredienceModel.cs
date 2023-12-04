using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IMedicationActiveIngredienceModel
    {
        MedicationActiveIngredienceModel Add(MedicationActiveIngredienceModel model);
        MedicationActiveIngredienceModel Remove(MedicationActiveIngredienceModel model);
        List<MedicationActiveIngredienceModel> GetAll();
        MedicationActiveIngredienceModel GetById(int id);
    }
}
