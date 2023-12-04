using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespMedicationCategory : IMedicationCategory
    {
        private DBCONTEX dBCONTEX;
        public RespMedicationCategory(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public MedicationCategoryModel Add(MedicationCategoryModel model)
        {
            dBCONTEX.MedicationCategoryTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<MedicationCategoryModel> GetAll()
        {
            return dBCONTEX.MedicationCategoryTbl.ToList();
        }

        public MedicationCategoryModel GetById(int id)
        {
            return dBCONTEX.MedicationCategoryTbl.FirstOrDefault(p => p.MedicationCategoryId == id);
        }

        public MedicationCategoryModel Remove(MedicationCategoryModel model)
        {
            throw new NotImplementedException();
        }
    }
}
