using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IMedicationCategory
    {
        MedicationCategoryModel Add(MedicationCategoryModel model);
        MedicationCategoryModel Remove(MedicationCategoryModel model);
        List<MedicationCategoryModel> GetAll();
        MedicationCategoryModel GetById(int id);
    }
}
