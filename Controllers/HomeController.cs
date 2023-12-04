using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project2022.Models.Interface;
using Project2022.Models.DataModel;
using Project2022.Models.DataBind;
using System.Text;
using System;

namespace Project2022.Controllers
{
    [AllowAnonymous]
    //[Authorize("Admin")]
    public class HomeController : Controller
    {
        private readonly IProvinceModel _provinceModel;
        private readonly ICityModel _cityModel;
        private readonly IGanderModel _ganderModel;
        private readonly IMedicationModel _medicationModel;
        private readonly IMedicationCategory _medicationCategory;
        private readonly IDosageFormModel _dosageFormModel;
        private readonly IDiagonosisModel _diagonosisModel;
        private readonly IActiveIngredientModel _activeIngredientModel;
        private readonly IMedicationActiveIngredienceModel _medicationActiveIngredienceModel;
        private readonly IPharmacModel _pharmacModel;
        private readonly IMedicalPrectiseModel _medicalPrectiseModel;
        private readonly IDoctorSpecializationModel _doctorSpecializationModel;
        public HomeController(IDoctorSpecializationModel doctorSpecializationModel,IMedicalPrectiseModel medicalPrectiseModel,IPharmacModel pharmacModel,IMedicationActiveIngredienceModel medicationActiveIngredienceModel,IActiveIngredientModel activeIngredientModel,IDiagonosisModel diagonosisModel,IDosageFormModel dosageFormModel,IMedicationCategory medicationCategory,IMedicationModel medicationModel,IGanderModel ganderModel, IMedicalPrectiseModel medicalPrectiseModel1, ICityModel cityModel, IProvinceModel provinceModel)
        {
            _medicationActiveIngredienceModel = medicationActiveIngredienceModel;
            _ganderModel = ganderModel;
            _doctorSpecializationModel = doctorSpecializationModel;
            _pharmacModel = pharmacModel;
            _medicalPrectiseModel = medicalPrectiseModel;
            _diagonosisModel = diagonosisModel;
            _activeIngredientModel = activeIngredientModel;
            _dosageFormModel = dosageFormModel;
            _medicationCategory = medicationCategory;
            _medicationModel = medicationModel;
            _cityModel = cityModel;
            _provinceModel = provinceModel;
        }
        //
        [HttpGet]
        public IActionResult DoctorSpecialization()
        {
            
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult DoctorSpecialization(DoctorSpecializationModel model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Data = "Doctor Specialization was added succesfully";
                _doctorSpecializationModel.Add(model);
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult CreateMedication()
        {
            ViewBag.DosageFormId = new SelectList(_dosageFormModel.GetAll(), "DosageFormId", "DosageFormName");
            ViewBag.MedicationCategoryId = new SelectList(_medicationCategory.GetAll(), "MedicationCategoryId", "MedicationCategoryName");
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateMedication(MedicationModel medicationModel)
        {
            if(ModelState.IsValid)
            {
                _medicationModel.Add(medicationModel);
                ViewBag.Data = "medication was added succesfully";
            }
            ViewBag.DosageFormId = new SelectList(_dosageFormModel.GetAll(), "DosageFormId", "DosageFormName");
            ViewBag.MedicationCategoryId = new SelectList(_medicationCategory.GetAll(), "MedicationCategoryId", "MedicationCategoryName");
            return View(medicationModel);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult MedicalPrectise(MedicalPrectiseModelRegister model)
        {
            if (ModelState.IsValid)
            {
                MedicalPrectiseModel pharmac = new MedicalPrectiseModel();
                pharmac.MedicalPrectiseName = model.MedicalPrectiseName;
                pharmac.AddressLine1 = model.AddressLine1;
                pharmac.AddressLine2 = model.AddressLine2;
                pharmac.FaxNumber = model.FaxNumber;
                pharmac.CityId = model.CityId;               
                pharmac.Email = model.Email;
                pharmac.TellNumber = model.TellNumber;
                pharmac.PostCode = model.PostCode;
                pharmac.MedicalPrectiseRegNumber = PrectiseRegNumber();
                pharmac.SuburbName = model.SuburbName;
                try
                {
                    _medicalPrectiseModel.Add(pharmac);
                }
                catch
                {
                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");
                }
                TempData["Succeeded"] = "Practise was registered Succesfully";
                return RedirectToAction("Succeeded", "Account");
            }
            ViewBag.ProvinceId = new SelectList(_provinceModel.GetAll(), "ProvinceId", "ProvinceName");
            return View(model);
        }
        [HttpGet]
        public IActionResult Pharmacy()
        {
            ViewBag.ProvinceId = new SelectList(_provinceModel.GetAll(), "ProvinceId", "ProvinceName");
            return View();
        }
        [HttpGet]
        public IActionResult MedicalPrectise()
        {
            ViewBag.ProvinceId = new SelectList(_provinceModel.GetAll(), "ProvinceId", "ProvinceName");
            return View();
        }
        private string PharmacyRegNumber()
        {
            const string letter = "123456789";
            StringBuilder res = new StringBuilder();
            int z = 8;
            Random rndm = new Random();
            while (0 < z--)
            {
                res.Append(letter[rndm.Next(letter.Length)]);
            }
            return "SA-R" + res.ToString();

        }
        private string PrectiseRegNumber()
        {
            const string letter = "1234";
            StringBuilder res = new StringBuilder();
            int z = 8;
            Random rndm = new Random();
            while (0 < z--)
            {
                res.Append(letter[rndm.Next(letter.Length)]);
            }
            return "PREC-R" + res.ToString();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Pharmacy(PharmacModelRegiser model)
        {
            if (ModelState.IsValid)
            {
                PharmacModel pharmac = new PharmacModel();
                pharmac.PharmacName = model.PharmacName;
                pharmac.AddressLine1 = model.AddressLine1;
                pharmac.AddressLine2 = model.AddressLine2;
                pharmac.FaxNumber = model.FaxNumber;
                pharmac.CityId = model.CityId;               
                pharmac.Email = model.Email;
                pharmac.TellNumber = model.TellNumber;
                pharmac.PostCode = model.PostCode;
                pharmac.PharmacRegNumber = PharmacyRegNumber();
                pharmac.SuburbName = model.SuburbName;
                try
                {
                    _pharmacModel.Add(pharmac);
                }
                catch
                {
                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");
                }
                TempData["Succeeded"] = "Pharmacy was registered Succesfully";
                return RedirectToAction("Succeeded", "Account");
            }
            ViewBag.ProvinceId = new SelectList(_provinceModel.GetAll(), "ProvinceId", "ProvinceName");
            return View(model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateMedicationCategory(MedicationCategoryModel model)
        {
            if(ModelState.IsValid)
            {
                ViewBag.Data = "Medication Category was add succesfully";
                _medicationCategory.Add(model);
            }
            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateDosageForm(DosageFormModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Data = "Dosage Form type was add succesfully";
                _dosageFormModel.Add(model);
            }
            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateDiagonosis(DiagonosisModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Data = "Diagonosis was add succesfully";
                _diagonosisModel.Add(model);
            }
            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateActiveIngredient(ActiveIngredientModel model)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Data = "Active Ingredient was add succesfully";
                _activeIngredientModel.Add(model);
            }
            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateMedicationActiveIngredience(MedicationActiveIngredienceModel model)
        {
            
            if (ModelState.IsValid)
            {
                ViewBag.Data = "Medication Active Ingredience was add succesfully";
                _medicationActiveIngredienceModel.Add(model);
            }
            ViewBag.MedicationId = new SelectList(_medicationModel.GetAll(), "MedicationId", "MedicationName");
            ViewBag.ActiveIngredientId = new SelectList(_activeIngredientModel.GetAll(), "ActiveIngredientId", "ActiveIngredientName");
            return View(model);
        }
        [HttpGet]
        public IActionResult CreateMedicationCategory()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateDosageForm()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateDiagonosis()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateActiveIngredient()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateMedicationActiveIngredience()
        {
            ViewBag.MedicationId = new SelectList(_medicationModel.GetAll(), "MedicationId", "MedicationName");
            ViewBag.ActiveIngredientId = new SelectList(_activeIngredientModel.GetAll(), "ActiveIngredientId", "ActiveIngredientName");
            return View();
        }
        [HttpGet]
        public IActionResult CreateGander()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateProvince()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateCity()
        {
            ViewBag.ProvinceId = new SelectList(_provinceModel.GetAll(), "ProvinceId", "ProvinceName");
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateGander(GanderModel model)
        {
            if(ModelState.IsValid)
            {
                _ganderModel.Add(model);
               ViewBag.Succeeded = "Gander was Added Succesfully";
            }
            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateProvince(ProvinceModel model)
        {
            if (ModelState.IsValid)
            {
                _provinceModel.Add(model);
                ViewBag.Succeeded = "Province was Added Succesfully";
            }
            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult CreateCity(CityModel model)
        {
            if (ModelState.IsValid)
            {
                _cityModel.Add(model);
                ViewBag.Succeeded = "City was Added Succesfully";
       
            }
            ViewBag.ProvinceId = new SelectList(_provinceModel.GetAll(), "ProvinceId", "ProvinceName");
            return View(model);
        }
    }
}
