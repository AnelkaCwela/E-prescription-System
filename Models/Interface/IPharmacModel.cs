using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IPharmacModel
    {
        PharmacModel Add(PharmacModel model);
        PharmacModel Remove(PharmacModel model);
        List<PharmacModel> GetAll();
        PharmacModel GetById(int id);
    }
}
