using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
   
    public class RespDiagonosisModel: IDiagonosisModel
    {
        private DBCONTEX dBCONTEX;
        public RespDiagonosisModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }

        public DiagonosisModel Add(DiagonosisModel model)
        {
            dBCONTEX.DiagonosisTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<DiagonosisModel> GetAll()
        {
            return dBCONTEX.DiagonosisTbl.ToList();
        }
   
        public DiagonosisModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public DiagonosisModel Remove(DiagonosisModel model)
        {
            throw new NotImplementedException();
        }
    }
}
