using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespMedicalPrectiseModel : IMedicalPrectiseModel
    {
        private DBCONTEX dBCONTEX;
        public RespMedicalPrectiseModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public MedicalPrectiseModel Add(MedicalPrectiseModel model)
        {
            dBCONTEX.MedicalPrectiseTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<MedicalPrectiseModel> GetAll()
        {
            return dBCONTEX.MedicalPrectiseTbl.ToList();
        }

        public MedicalPrectiseModel GetById(int id)
        {
            return dBCONTEX.MedicalPrectiseTbl.FirstOrDefault(p => p.MedicalPrectiseId == id);
        }

        public MedicalPrectiseModel Remove(MedicalPrectiseModel model)
        {
            throw new NotImplementedException();
        }
    }
}
