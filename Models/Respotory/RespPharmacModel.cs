using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespPharmacModel : IPharmacModel
    {
        private DBCONTEX dBCONTEX;
        public RespPharmacModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public PharmacModel Add(PharmacModel model)
        {
            dBCONTEX.PharmacTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<PharmacModel> GetAll()
        {
            return dBCONTEX.PharmacTbl.ToList();
        }

        public PharmacModel GetById(int id)
        {
            return dBCONTEX.PharmacTbl.FirstOrDefault(p => p.PharmacId == id);
        }

        public PharmacModel Remove(PharmacModel model)
        {
            throw new NotImplementedException();
        }
    }
}
