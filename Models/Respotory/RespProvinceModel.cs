using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespProvinceModel : IProvinceModel
    {
        private DBCONTEX dBCONTEX;
        public RespProvinceModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;   
        }
        ProvinceModel IProvinceModel.Add(ProvinceModel model)
        {
          dBCONTEX.ProvinceTbl.Add(model); 
           dBCONTEX.SaveChanges();
            return model;   
 
        }

        List<ProvinceModel> IProvinceModel.GetAll()
        {
         return   dBCONTEX.ProvinceTbl.ToList();
        }

        ProvinceModel IProvinceModel.GetById(int id)
        {
          var model= dBCONTEX.ProvinceTbl.FirstOrDefault(p => p.ProvinceId == id);
            return model;
        }

        ProvinceModel IProvinceModel.Remove(ProvinceModel model)
        {
            throw new NotImplementedException();
        }
    }
}
