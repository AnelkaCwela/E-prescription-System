using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Rendering;
using Project2022.Models.Interface;
using Project2022.Models.DataModel;
using Project2022.Models.DataBind;

namespace Project2022.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IPatientUserModel _patientUserModel;
        private readonly IDoctorUserModel _doctorUserModel;
        private readonly IMedicalHistoryModel _medicalHistoryModel;
        private readonly ICurrentVistModel _currentVistModel;
       private readonly IDiagonosisModel _diagonosisModel;
        private readonly IMedicationModel _medicationModel;
        public readonly IActiveIngredientModel _activeIngredientModel;
        public readonly IAllergyModel _allergyModel;
        public readonly IPrescriptionModel _prescriptionModel;
       public DoctorController(ICurrentVistModel currentVistModel,IPrescriptionModel prescriptionModel,IAllergyModel allergyModel,IActiveIngredientModel activeIngredientModel,IMedicationModel medicationModel,IDiagonosisModel diagonosisModel,IPatientUserModel patientUserModel, IDoctorUserModel doctorUserModel, IMedicalHistoryModel medicalHistoryModel)
        {
            _patientUserModel = patientUserModel;
            _currentVistModel = currentVistModel;
            _prescriptionModel = prescriptionModel;
            _allergyModel = allergyModel;
            _medicalHistoryModel = medicalHistoryModel;
            _doctorUserModel = doctorUserModel;
            _diagonosisModel = diagonosisModel;
            _medicationModel = medicationModel;
            _activeIngredientModel = activeIngredientModel;
        }
        [HttpGet]
        public IActionResult Index(int PatientId)
        {
            if (PatientId<=0)
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            PrescriptionModel Patient = new PrescriptionModel();
            Patient.PatientId = PatientId;
            ViewBag.MedicationId = new SelectList(_medicationModel.GetAll(), "MedicationId", "MedicationName");
            return View(Patient);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(PrescriptionModel model)
        {
            if (ModelState.IsValid)
            {
                var Doctor = _doctorUserModel.GetByEmail(User.Identity.Name);
                if (Doctor != null)
                {
                    model.PrescriptionDate = DateTime.Now;
                    if (_prescriptionModel.Add(model)!=null)
                    {
                        ViewBag.Data = "Prescripion was  load succesfully";
                        ViewBag.MedicationId = new SelectList(_medicationModel.GetAll(), "MedicationId", "MedicationName");
                        return View(model);
                    }
                    else
                    {
                        ViewBag.Data = "We were not able to load prescription";
                        ViewBag.MedicationId = new SelectList(_medicationModel.GetAll(), "MedicationId", "MedicationName");
                        return View(model);
                    }

                }
                else
                {
                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");
                }
            }
            ViewBag.MedicationId = new SelectList(_medicationModel.GetAll(), "MedicationId", "MedicationName");
            return View(model);
        }
        public PatientDetialViewModel Index(PatientUserModel patient)
        {
            PatientDetialViewModel Model = new PatientDetialViewModel();
            if (patient!=null)
            {
                Model.patientUserModel = patient;
                List<MedicalHistoryModel> dignoss = _medicalHistoryModel.GetAllByPatientId(patient.PatientId);//
                if(dignoss!=null)
                {
                    foreach(var data in dignoss)
                    {
                        if(data!=null)
                        {
                            DiagonosisModel diagnossData =_diagonosisModel.GetById(data.DiagonosisId);
                            if (diagnossData!=null)
                            {
                                Model.diagonosisModels.Add(diagnossData);
                              
                            }
                        }
                    }
                }
                 List<AllergyModel> Allegy = _allergyModel.GetAllPatientId(patient.PatientId);
                if (Allegy != null)
                {
                    foreach (var data in Allegy)
                    {
                        if (data != null)
                        {
                            ActiveIngredientModel active = _activeIngredientModel.GetById(data.PatientId);
                            if (active != null)
                            {
                                Model.activeIngredientModels.Add(active);
                            }
                        }
                    }
                }
                List<PrescriptionModel> medicataiom = _prescriptionModel.GetAllByPatientId(patient.PatientId);
                if (medicataiom != null)
                {
                    foreach (var data in medicataiom)
                    {
                        if (data != null)
                        {
                            MedicationModel med = _medicationModel.GetById(data.PatientId);
                            if (med != null)
                            {   
                                Model.patientMedication.Add(med);
                            }
                        }
                    }
                }

            }
          
            
            return Model;
        }
        [HttpPost]
        public IActionResult Search(string IdentityNumber)
        {
            PatientUserModel patient = null;
  
            try
            {
                patient = _patientUserModel.GetByIdentityNo(IdentityNumber);
            }
            catch
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            if(patient!=null)
            {
                if(patient.HasVistedDoctor==true)
                {

                    try
                    {
                        if (TempData["Data"] != null)
                        {
                            ViewBag.Data = TempData["Data"];
                            TempData.Clear();
                        }
                        return View(Index(patient));
                    }
                    catch
                    {
                        TempData["Error"] = "Somthing Went Wrong Please Try Again";
                        return RedirectToAction("Error", "Account");
                    }
                }
                else
                {
                    return RedirectToAction("Allergy", "Doctor",new { Id=patient.PatientId});
                }
            }
            else
            {
                TempData["Error"] = "We did not find the patient with matching Identity Number " + IdentityNumber;
                return RedirectToAction("Error", "Account");
            }
           
        }
        [HttpGet]
        public IActionResult MedicalHistory(int Id)
        {
            if (Id > 0)
            {
                MedicalHistoryModel allergy = new MedicalHistoryModel();
                allergy.PatientId = Id;
                ViewBag.DiagonosisId = new SelectList(_diagonosisModel.GetAll(), "DiagonosisId", "DiagonosisDescription");
                if(patient(Id))
                {
                    return View(allergy);
                }
                else
                {
                   TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");                    
                }
            }
            else
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
        }
        [HttpGet]
        public IActionResult Allergy(int Id)
        {
            if (Id>0)
            {
                AllergyModel allergy = new AllergyModel();
                allergy.PatientId = Id;
                ViewBag.ActiveIngredientId = new SelectList(_activeIngredientModel.GetAll(), "ActiveIngredientId", "ActiveIngredientName");
                if (patient(Id))
                {
                    return View(allergy);
                }
                else
                {
                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");
                }
            }
            else
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
        }
        public bool patient(int PataientId)
        {
            var patient = _patientUserModel.GetById(PataientId);
            if(patient!=null)
            {
                ViewBag.Name = patient.FirstName;
                ViewBag.Surname = patient.LastName;
                ViewBag.Identity = patient.LastName;
                return true;
            }
            else
            {
                return false;
            }
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult MedicalHistory(MedicalHistoryModel allergy)
        {
            if (ModelState.IsValid)
            {
                try
                {
                  var allery=  _medicalHistoryModel.Add(allergy);
                    ViewBag.Allergy= "Medical History was Added Succesfully";
                    if (patient(allergy.PatientId))
                    {
                        if (allery != null)
                        {
                            if (_patientUserModel.GetById(allergy.PatientId).HasVistedDoctor == false)
                            {
                                _patientUserModel.UpdateVIST(allergy.PatientId);
                            }

                        }
                        return View(allergy);
                    }
                    else
                    {
                        TempData["Error"] = "Somthing Went Wrong Please Try Again";
                        return RedirectToAction("Error", "Account");
                    }
                }
                catch
                {
                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");
                }
            }
            ViewBag.DiagonosisId = new SelectList(_diagonosisModel.GetAll(), "DiagonosisId", "DiagonosisDescription");
            return View(allergy);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Allergy(AllergyModel allergy)
        {
            if (ModelState.IsValid)
            {
                try
                {
                 var allery= _allergyModel.Add(allergy);
                    ViewBag.Allergy = "Allergy was Added Succesfully";
                    if (patient(allergy.PatientId))
                    {
                        if(allery!=null)
                        {
                            if (_patientUserModel.GetById(allergy.PatientId).HasVistedDoctor==false)
                            {
                                _patientUserModel.UpdateVIST(allergy.PatientId);
                            }

                        }
                        return View(allergy);
                    }
                    else
                    {
                        TempData["Error"] = "Somthing Went Wrong Please Try Again";
                        return RedirectToAction("Error", "Account");
                    }
                }
                catch
                {
                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");
                }
            }
            ViewBag.ActiveIngredientId = new SelectList(_activeIngredientModel.GetAll(), "ActiveIngredientId", "ActiveIngredientName");
            return View(allergy);
        }

        public IActionResult CurrentVist(int PatientId)
        {
            if(PatientId>0)
            {
                try
                {
                    var Doctor = _doctorUserModel.GetByEmail(User.Identity.Name);
                    if (Doctor!=null)
                    {
                        CurrentVistModel mode = new CurrentVistModel();
                        mode.DoctorId = Doctor.DoctorId;
                        mode.PatientId = PatientId;
                        mode.VisDate = DateTime.Now;

                        _currentVistModel.Add(mode);
                        TempData["Data"] = "Current Visit Captured";
                        return RedirectToAction("Search", "Doctor");

                    }
                    else
                    {
                        TempData["Error"] = "Somthing Went Wrong Please Try Again";
                        return RedirectToAction("Error", "Account");
                    }
                }
                catch
                {
                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");
                }
            }
            else
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
   
        }
        
    }
}
