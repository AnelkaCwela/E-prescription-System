using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespDoctorAlertModel : IDoctorAlertModel
    {
        private DBCONTEX dBCONTEX;
        public RespDoctorAlertModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public DoctorAlertModel Add(DoctorAlertModel model)
        {
            dBCONTEX.DoctorAlertTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<DoctorAlertModel> GetAll()
        {
            return dBCONTEX.DoctorAlertTbl.ToList();
        }

        public DoctorAlertModel GetById(int id)
        {
            return dBCONTEX.DoctorAlertTbl.FirstOrDefault(p => p.DoctorAlertId == id);
        }

        public DoctorAlertModel Remove(DoctorAlertModel model)
        {
            throw new NotImplementedException();
        }
    }
}
