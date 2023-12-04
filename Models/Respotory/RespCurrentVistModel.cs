using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2022.Models.Respotory
{
    public class RespCurrentVistModel: ICurrentVistModel
    {
        private DBCONTEX dBCONTEX;
        public RespCurrentVistModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }

        public CurrentVistModel Add(CurrentVistModel model)
        {
            dBCONTEX.CurrentVistTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<CurrentVistModel> GetAll()
        {
            return dBCONTEX.CurrentVistTbl.ToList();
        }
    }
}
