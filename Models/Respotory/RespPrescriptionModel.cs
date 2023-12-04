using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespPrescriptionModel : IPrescriptionModel
    {
        private DBCONTEX dBCONTEX;
        public RespPrescriptionModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public PrescriptionModel Add(PrescriptionModel model)
        {
            dBCONTEX.PrescriptionTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<PrescriptionModel> GetAll()
        {
            return dBCONTEX.PrescriptionTbl.ToList();
        }
        public List<PrescriptionModel> GetAllByPatientId(int PatientId)
        {
            return dBCONTEX.PrescriptionTbl.Where(p=>p.PatientId==PatientId).ToList();
        }

        public PrescriptionModel GetById(int id)
        {
            return dBCONTEX.PrescriptionTbl.FirstOrDefault(p => p.PrescriptionId == id);
         
        }

        public PrescriptionModel Remove(PrescriptionModel model)
        {
            throw new NotImplementedException();
        }
    }
}
