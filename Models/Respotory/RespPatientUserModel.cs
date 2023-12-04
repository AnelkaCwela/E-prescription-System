using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespPatientUserModel : IPatientUserModel
    {
        private DBCONTEX dBCONTEX;
        public RespPatientUserModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public PatientUserModel Add(PatientUserModel model)
        {
            dBCONTEX.PatientUserTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<PatientUserModel> GetAll()
        {
            return dBCONTEX.PatientUserTbl.ToList();
        }

        public PatientUserModel GetById(int id)
        {
            return dBCONTEX.PatientUserTbl.FirstOrDefault(p => p.PatientId == id);
        }
        public PatientUserModel GetByIdentityNo(string id)
        {
            return dBCONTEX.PatientUserTbl.FirstOrDefault(p => p.IdendityNumber == id);
        }

        public PatientUserModel Remove(PatientUserModel model)
        {
            throw new NotImplementedException();
        }
        public PatientUserModel Update(PatientUserModel model)
        {
            throw new NotImplementedException();
        }
        public PatientUserModel UpdateVIST(int Id)
        {
            var Data =  dBCONTEX.PatientUserTbl.FirstOrDefault(x => x.PatientId == Id);
            if (Data != null)
            {
                Data.HasVistedDoctor = true;


                var save = dBCONTEX.PatientUserTbl.Attach(Data);
                save.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                 dBCONTEX.SaveChanges();

            }
            return Data;
        }
    }
}
