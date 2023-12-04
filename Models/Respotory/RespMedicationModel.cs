using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespMedicationModel : IMedicationModel
    {
        private DBCONTEX dBCONTEX;
        public RespMedicationModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public MedicationModel Add(MedicationModel model)
        {
            dBCONTEX.MedicationTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<MedicationModel> GetAll()
        {
            return dBCONTEX.MedicationTbl.ToList();
        }

        public MedicationModel GetById(int id)
        {
            return dBCONTEX.MedicationTbl.FirstOrDefault(p => p.MedicationId == id);
        }

        public MedicationModel Remove(MedicationModel model)
        {
            throw new NotImplementedException();
        }
    }
}
