using Project2022.Models.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project2022.Models.Interface
{
    public interface ICurrentVistModel
    {
        CurrentVistModel Add(CurrentVistModel model);
        List<CurrentVistModel> GetAll();

    }
}
