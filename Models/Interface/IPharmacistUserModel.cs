using Project2022.Models.DataModel;
using System.Collections.Generic;

namespace Project2022.Models.Interface
{
    public interface IPharmacistUserModel
    {
        PharmacistUserModel Add(PharmacistUserModel model);
        PharmacistUserModel Remove(PharmacistUserModel model);
        List<PharmacistUserModel> GetAll();
        PharmacistUserModel GetById(int id);
        PharmacistUserModel Update(PharmacistUserModel model);
    }
}
