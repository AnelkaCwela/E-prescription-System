using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Project2022.Models.Respotory
{
    public class RespAdminModel: IAdminUserModel
    {
        private DBCONTEX dBCONTEX;
        public RespAdminModel(DBCONTEX dBCONTEX)
        {
            this.dBCONTEX = dBCONTEX;
        }
        public AdminUserModel Add(AdminUserModel model)
        {
            dBCONTEX.AdminUserTbl.Add(model);
            dBCONTEX.SaveChanges();
            return model;
        }

        public List<AdminUserModel> GetAll()
        {
            return dBCONTEX.AdminUserTbl.ToList();
        }

        public AdminUserModel GetById(int id)
        {
            return dBCONTEX.AdminUserTbl.FirstOrDefault(p => p.AdminId == id);
        }

        public AdminUserModel Remove(AdminUserModel model)
        {
            throw new NotImplementedException();
        }
        public AdminUserModel Update(AdminUserModel model)
        {
            throw new NotImplementedException();
        }
    }
}
