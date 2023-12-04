using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespPharmacistUserModel : IPharmacistUserModel
    {
        private DBCONTEX dBCONTEX;
        public RespPharmacistUserModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public PharmacistUserModel Add(PharmacistUserModel model)
        {
            dBCONTEX.PharmacistUserTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<PharmacistUserModel> GetAll()
        {
            return dBCONTEX.PharmacistUserTbl.ToList();
        }

        public PharmacistUserModel GetById(int id)
        {
            return dBCONTEX.PharmacistUserTbl.FirstOrDefault(p => p.PharmacId == id);
        }

        public PharmacistUserModel Remove(PharmacistUserModel model)
        {
            throw new NotImplementedException();
        }
        public PharmacistUserModel Update(PharmacistUserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
