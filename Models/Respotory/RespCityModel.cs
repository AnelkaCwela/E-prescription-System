using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespCityModel: ICityModel
    {
        private DBCONTEX dBCONTEX;
        public RespCityModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public CityModel Add(CityModel model)
        {
            dBCONTEX.CityTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<CityModel> GetAll()
        {
            return dBCONTEX.CityTbl.ToList();
        }
        public List<CityModel> GetAllByProvimce(int Id)
        {
            return dBCONTEX.CityTbl.Where(o=>o.ProvinceId == Id).ToList();  
        }
        //

        public CityModel GetById(int id)
        {
            return dBCONTEX.CityTbl.FirstOrDefault(p => p.CityId == id);
        }
        public CityModel GetByProvimceId(int Id)
        {
            return dBCONTEX.CityTbl.FirstOrDefault(p => p.ProvinceId == Id);
        }

        public CityModel Remove(CityModel model)
        {
            throw new NotImplementedException();
        }
        public CityModel Update(CityModel model)
        {
            throw new NotImplementedException();
        }
    }
}
