using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IDosageFormModel
    {
        DosageFormModel Add(DosageFormModel model);
        DosageFormModel Remove(DosageFormModel model);
        List<DosageFormModel> GetAll();
        DosageFormModel GetById(int id);
    }
}
