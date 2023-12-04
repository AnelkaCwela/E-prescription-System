using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespAllergyModel : IAllergyModel
    {
        private DBCONTEX dBCONTEX;
        public RespAllergyModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public AllergyModel Add(AllergyModel model)
        {
            throw new NotImplementedException();
        }

        public List<AllergyModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<AllergyModel> GetAllPatientId(int Id)
        {
            return dBCONTEX.AllergyTbl.Where(op => op.PatientId == Id).ToList();
        }

        public AllergyModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public AllergyModel Remove(AllergyModel model)
        {
            throw new NotImplementedException();
        }
    }
}
