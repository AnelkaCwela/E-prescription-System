using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespGanderModel : IGanderModel
    {
        private DBCONTEX dBCONTEX;
        public RespGanderModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public GanderModel Add(GanderModel model)
        {
            dBCONTEX.GanderTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<GanderModel> GetAll()
        {
            return dBCONTEX.GanderTbl.ToList();
        }

        public GanderModel GetById(int id)
        {
            return dBCONTEX.GanderTbl.FirstOrDefault(p => p.GanderId == id);
        }

        public GanderModel Remove(GanderModel model)
        {
            throw new NotImplementedException();
        }
    }
}
