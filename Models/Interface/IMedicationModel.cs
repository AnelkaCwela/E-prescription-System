﻿using Project2022.Models.DataModel;
using System.Collections.Generic;
namespace Project2022.Models.Interface
{
    public interface IMedicationModel
    {
        MedicationModel Add(MedicationModel model);
        MedicationModel Remove(MedicationModel model);
        List<MedicationModel> GetAll();
        MedicationModel GetById(int id);
    }
}
