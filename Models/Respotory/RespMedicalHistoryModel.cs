using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2022.Models.Respotory
{
    public class RespMedicalHistoryModel : IMedicalHistoryModel
    {
        private DBCONTEX dBCONTEX;
        public RespMedicalHistoryModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public MedicalHistoryModel Add(MedicalHistoryModel model)
        {
            dBCONTEX.MedicalHistoryTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;

        }

        public List<MedicalHistoryModel> GetAll()
        {
           return dBCONTEX.MedicalHistoryTbl.ToList();
        }

        public List<MedicalHistoryModel> GetAllByPatientId(int patientId)
        {
            return dBCONTEX.MedicalHistoryTbl.Where(p => p.PatientId == patientId).ToList();
        }

        public MedicalHistoryModel GetById(int id)
        {
            return dBCONTEX.MedicalHistoryTbl.FirstOrDefault(p => p.PatientId == id);
        }

        public MedicalHistoryModel Remove(MedicalHistoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
