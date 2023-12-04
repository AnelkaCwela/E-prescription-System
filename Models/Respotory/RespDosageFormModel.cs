using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespDosageFormModel : IDosageFormModel
    {
        private DBCONTEX dBCONTEX;
        public RespDosageFormModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public DosageFormModel Add(DosageFormModel model)
        {
            dBCONTEX.DosageFormTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<DosageFormModel> GetAll()
        {
            return dBCONTEX.DosageFormTbl.ToList();
        }

        public DosageFormModel GetById(int id)
        {
            return dBCONTEX.DosageFormTbl.FirstOrDefault(p => p.DosageFormId == id);
        }

        public DosageFormModel Remove(DosageFormModel model)
        {
            throw new NotImplementedException();
        }
    }
}
