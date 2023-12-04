using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IProvinceModel
    {
        ProvinceModel Add(ProvinceModel model);
        ProvinceModel Remove(ProvinceModel model);
        List<ProvinceModel> GetAll();
        ProvinceModel GetById(int id);
    }
}
