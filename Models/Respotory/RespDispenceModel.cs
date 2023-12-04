using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespDispenceModel : IDispenceModel
    {
        private DBCONTEX dBCONTEX;
        public RespDispenceModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public DispenceModel Add(DispenceModel model)
        {
            dBCONTEX.DispenceModelTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<DispenceModel> GetAll()
        {
            return dBCONTEX.DispenceModelTbl.ToList();
        }

        public DispenceModel GetById(int id)
        {
            return dBCONTEX.DispenceModelTbl.FirstOrDefault(p => p.PrescriptionId == id);
        }

        public DispenceModel Remove(DispenceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
