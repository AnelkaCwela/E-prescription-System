using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IDiagonosisModel
    {
        DiagonosisModel Add(DiagonosisModel model);
        DiagonosisModel Remove(DiagonosisModel model);
        List<DiagonosisModel> GetAll();
        DiagonosisModel GetById(int id);
    }
}
