using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespDoctorUserModel:IDoctorUserModel
    {
        private DBCONTEX dBCONTEX;
        public RespDoctorUserModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public DoctorUserModel Add(DoctorUserModel model)
        {
            dBCONTEX.DoctorUserTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<DoctorUserModel> GetAll()
        {
            return dBCONTEX.DoctorUserTbl.ToList();
        }

        public DoctorUserModel GetByEmail(string id)
        {
            return dBCONTEX.DoctorUserTbl.FirstOrDefault(p => p.Email == id);
        }

        public DoctorUserModel GetById(int id)
        {
            return dBCONTEX.DoctorUserTbl.FirstOrDefault(p => p.DoctorId == id);
        }

        public DoctorUserModel Remove(DoctorUserModel model)
        {
            throw new NotImplementedException();
        }
        public DoctorUserModel Update(DoctorUserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
