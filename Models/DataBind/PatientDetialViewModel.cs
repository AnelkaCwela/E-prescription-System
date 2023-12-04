using Project2022.Models.DataModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project2022.Models.DataBind
{
    public class PatientDetialViewModel
    {
        [Key]
        public int PatientId { get; set; }
        public PatientUserModel patientUserModel { get; set; }
        public List<MedicationModel> patientMedication { get; set; }
        public List<ActiveIngredientModel> activeIngredientModels { get; set; }
        public List<DiagonosisModel> diagonosisModels { get; set; }
    }
}
