using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespMedicationActiveIngredienceModel : IMedicationActiveIngredienceModel
    {
        private DBCONTEX dBCONTEX;
        public RespMedicationActiveIngredienceModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public MedicationActiveIngredienceModel Add(MedicationActiveIngredienceModel model)
        {
            dBCONTEX.MedicationActiveIngredienceTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<MedicationActiveIngredienceModel> GetAll()
        {
            return dBCONTEX.MedicationActiveIngredienceTbl.ToList();
        }

        public MedicationActiveIngredienceModel GetById(int id)
        {
            return dBCONTEX.MedicationActiveIngredienceTbl.FirstOrDefault(p => p.MedicationActiveIngredienceId == id);
        }

        public MedicationActiveIngredienceModel Remove(MedicationActiveIngredienceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
