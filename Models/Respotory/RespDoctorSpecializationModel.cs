using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespDoctorSpecializationModel : IDoctorSpecializationModel
    {
        private DBCONTEX dBCONTEX;
        public RespDoctorSpecializationModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public DoctorSpecializationModel Add(DoctorSpecializationModel model)
        {
            dBCONTEX.DoctorSpecializationTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<DoctorSpecializationModel> GetAll()
        {
            return dBCONTEX.DoctorSpecializationTbl.ToList();
        }

        public DoctorSpecializationModel GetById(int id)
        {
            return dBCONTEX.DoctorSpecializationTbl.FirstOrDefault(p => p.DoctorSpecializationId == id);
        }

        public DoctorSpecializationModel Remove(DoctorSpecializationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
