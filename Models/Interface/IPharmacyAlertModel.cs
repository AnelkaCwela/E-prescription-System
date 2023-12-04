using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IPharmacyAlertModel
    {
        PharmacyAlertModel Add(PharmacyAlertModel model);
        PharmacyAlertModel Remove(PharmacyAlertModel model);
        List<PharmacyAlertModel> GetAll();
        PharmacyAlertModel GetById(int id);
    }
}
