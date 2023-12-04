using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface ICityModel
    {
        CityModel Add(CityModel model);
        CityModel Remove(CityModel model);
        List<CityModel> GetAll();
        List<CityModel> GetAllByProvimce(int Id);
       CityModel GetByProvimceId(int Id);
        CityModel GetById(int id);
    }
}
