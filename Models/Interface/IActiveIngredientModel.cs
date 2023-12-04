using Project2022.Models.DataModel;
using System.Collections.Generic;

namespace Project2022.Models.Interface
{
    public interface IActiveIngredientModel
    {
        ActiveIngredientModel Add(ActiveIngredientModel model);
        ActiveIngredientModel Remove(ActiveIngredientModel model);
        List<ActiveIngredientModel> GetAll();
        ActiveIngredientModel GetById(int id);
    }
}
