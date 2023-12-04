using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespPharmacyAlertModel : IPharmacyAlertModel
    {
        private DBCONTEX dBCONTEX;
        public RespPharmacyAlertModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public PharmacyAlertModel Add(PharmacyAlertModel model)
        {
            dBCONTEX.PharmacyAlertTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<PharmacyAlertModel> GetAll()
        {
            return dBCONTEX.PharmacyAlertTbl.ToList();
        }

        public PharmacyAlertModel GetById(int id)
        {
            return dBCONTEX.PharmacyAlertTbl.FirstOrDefault(p => p.PharmacyAlertId == id);
        }

        public PharmacyAlertModel Remove(PharmacyAlertModel model)
        {
            throw new NotImplementedException();
        }
    }
}
