using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespPatientMedicationModel : IPatientMedicationModel
    {
        private DBCONTEX dBCONTEX;
        public RespPatientMedicationModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public PatientMedicationModel Add(PatientMedicationModel model)
        {
            dBCONTEX.PatientMedicationTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<PatientMedicationModel> GetAll()
        {
            return dBCONTEX.PatientMedicationTbl.ToList();
        }

        public PatientMedicationModel GetById(int id)
        {
            return dBCONTEX.PatientMedicationTbl.FirstOrDefault(p => p.PatientMedicationId == id);
        }

        public PatientMedicationModel Remove(PatientMedicationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
