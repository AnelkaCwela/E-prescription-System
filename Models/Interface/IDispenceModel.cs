using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IDispenceModel
    {
        DispenceModel Add(DispenceModel model);
        DispenceModel Remove(DispenceModel model);
        List<DispenceModel> GetAll();
        DispenceModel GetById(int id);
    }
}
