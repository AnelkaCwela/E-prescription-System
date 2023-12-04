using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2022.Models.Respotory
{
    public class RespActiveIngredientModel : IActiveIngredientModel
    {
        private DBCONTEX dBCONTEX;
        public RespActiveIngredientModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public ActiveIngredientModel Add(ActiveIngredientModel model)
        {
            dBCONTEX.ActiveIngredientTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<ActiveIngredientModel> GetAll()
        {
            return dBCONTEX.ActiveIngredientTbl.ToList();
        }

        public ActiveIngredientModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public ActiveIngredientModel Remove(ActiveIngredientModel model)
        {
            throw new NotImplementedException();
        }
    }
}
