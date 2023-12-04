using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IAllergyModel
    {
        AllergyModel Add(AllergyModel model);
        AllergyModel Remove(AllergyModel model);
        List<AllergyModel> GetAll();
        List<AllergyModel> GetAllPatientId(int Id);
        AllergyModel GetById(int id);
    }
}
