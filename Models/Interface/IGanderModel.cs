using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface  IGanderModel
    {
        GanderModel Add(GanderModel model);
        GanderModel Remove(GanderModel model);
        List<GanderModel> GetAll();
        GanderModel GetById(int id);
    }
}
