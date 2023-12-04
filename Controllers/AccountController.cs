using Project2022.Models.DataBind;
using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
namespace Project2022.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<UserModel> _userManager;
        private readonly SignInManager<UserModel> _signInManager;
        private readonly RoleManager<IdentityRoleModel> _RoleManger;
        private readonly IPatientUserModel _patientUserModel;
        private readonly IDoctorUserModel _doctorUserModel;
        private readonly IPharmacistUserModel _PharmacistUserModel;
        private readonly IAdminUserModel _AdminUserModel;
        private readonly IDoctorSpecializationModel _doctorSpecializationModel;
        private readonly IPharmacModel _pharmacModel;
        private readonly IMedicalPrectiseModel _medicalPrectiseModel;
       
        private readonly IProvinceModel _provinceModel;
        private readonly ICityModel _cityModel;

        private readonly IGanderModel _ganderModel;
       public AccountController(IGanderModel ganderModel, ICityModel cityModel,IProvinceModel provinceModel,IPharmacModel pharmacModel,IDoctorSpecializationModel doctorSpecializationModel,IMedicalPrectiseModel medicalPrectiseModel,IAdminUserModel AdminUserModel, IPatientUserModel patientUserModel, IDoctorUserModel doctorUserModel, IPharmacistUserModel PharmacistUserModel, RoleManager<IdentityRoleModel> RoleManger, UserManager<UserModel> userManager, SignInManager<UserModel> signInManager)
        {
            _ganderModel = ganderModel;
            this._signInManager = signInManager;
            
            _cityModel = cityModel;
            _provinceModel = provinceModel;
            _pharmacModel = pharmacModel;
            _doctorSpecializationModel = doctorSpecializationModel;
            _medicalPrectiseModel = medicalPrectiseModel;
            _AdminUserModel = AdminUserModel;
            this._userManager = userManager;
            this._RoleManger = RoleManger;
            this._doctorUserModel = doctorUserModel;
            _patientUserModel = patientUserModel;
            this._PharmacistUserModel = PharmacistUserModel;   
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Welcome()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }


        [HttpGet]

        public IActionResult ChangePassword()
        {
            if (User.Identity.Name == null)
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            return View();
        }
        [HttpPost]

        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ChangePassword(ChangePasswordModel model)
        {
            if (ModelState.IsValid)
            {
                if (User.Identity.Name != null)
                {
                    var Find_User = await _userManager.FindByEmailAsync(User.Identity.Name);
                    if (Find_User == null)
                    {
                        TempData["Error"] = "Somthing Went Wrong Please Try Again";
                        return RedirectToAction("Error", "Account");
                    }
                    var Change_Password = await _userManager.ChangePasswordAsync(Find_User, model.CurrentPassord, model.NewPassword);

                    if (Change_Password.Succeeded)
                    {
                        await _signInManager.SignInAsync(Find_User, isPersistent: true);

                        await _signInManager.SignOutAsync();
                        TempData["Succeeded"] = "The Password Was Changed Succesfull";
                        return RedirectToAction("Succeeded", "Account");

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

            return View(model);
        }
      
        [AutoValidateAntiforgeryToken]
        [HttpPost]
        public async Task<IActionResult> Edit(UserEditModel model)
        {
            if (ModelState.IsValid)
            {
                if (User.Identity.Name != null)
                {
                    var Find_User = await _userManager.FindByEmailAsync(User.Identity.Name);
                    if (Find_User != null)
                    {
                        if(model.UserType=="Patient")
                        {
                            PatientUserModel patientUserModel = new PatientUserModel();
                            patientUserModel.Email = model.Email;
                            patientUserModel.FirstName = model.FirstName;   
                              patientUserModel.LastName = model.LastName;   
                                patientUserModel.CellNumber = model.CellNumber;
                            try
                            {
                                if (_patientUserModel.Update(patientUserModel) != null)
                                {
                                  TempData["Succeeded"] = "Patient was updated succesfully";
                                  return RedirectToAction("Succeeded", "Account");
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
                        else if (model.UserType=="Doctor")
                        {
                            DoctorUserModel patientUserModel = new DoctorUserModel();
                            patientUserModel.Email = model.Email;
                            patientUserModel.FirstName = model.FirstName;
                            patientUserModel.LastName = model.LastName;
                            patientUserModel.CellNumber = model.CellNumber;
                            try
                            {
                                if (_doctorUserModel.Update(patientUserModel) != null)
                                {
                                    TempData["Succeeded"] = "Patient was updated succesfully";
                                    return RedirectToAction("Succeeded", "Account");
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
                        } else if (model.UserType =="Pharmacist" )
                        {
                            PharmacistUserModel patientUserModel = new PharmacistUserModel();
                            patientUserModel.Email = model.Email;
                            patientUserModel.FirstName = model.FirstName;
                            patientUserModel.LastName = model.LastName;
                            patientUserModel.CellNumber = model.CellNumber;
                            try
                            {
                                if (_PharmacistUserModel.Update(patientUserModel) != null)
                                {
                                    TempData["Succeeded"] = "Patient was updated succesfully";
                                    return RedirectToAction("Succeeded", "Account");
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
                        else if(model.UserType=="Admin")
                        {
                            AdminUserModel patientUserModel = new AdminUserModel();
                            patientUserModel.Email = model.Email;
                            patientUserModel.FirstName = model.FirstName;
                            patientUserModel.LastName = model.LastName;
                            patientUserModel.CellNumber = model.CellNumber;
                            try
                            {
                                if (_AdminUserModel.Update(patientUserModel) != null)
                                {
                                    TempData["Succeeded"] = "Patient was updated succesfully";
                                    return RedirectToAction("Succeeded", "Account");
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
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int Id)
        {
            UserEditModel Data = new UserEditModel();
            if (User.Identity.Name == null)
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            else
            {
                if(Id>0)
                {

                    var patient = _patientUserModel.GetById(Id);
                    if (patient == null)
                    {
                        var doctor = _doctorUserModel.GetById(Id);
                        if (doctor==null)
                        {
                            var pharmacis = _PharmacistUserModel.GetById(Id);
                            if (pharmacis==null)
                            {
                                var Admin = _AdminUserModel.GetById(Id);
                                if(Admin==null)
                                {
                                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                                    return RedirectToAction("Error", "Account");
                                }
                                else
                                {
                                    Data.FirstName = Admin.FirstName;
                                    Data.LastName = Admin.LastName;
                                    Data.Email = Admin.Email;
                                    Data.CellNumber = Admin.CellNumber;
                                    Data.UserType = "Admin";
                                }
                            }
                            else
                            {
                                Data.FirstName = pharmacis.FirstName;
                                Data.LastName = pharmacis.LastName;
                                Data.Email = pharmacis.Email;
                                Data.CellNumber = pharmacis.CellNumber;
                                Data.UserType = "Pharmacist";
                            }
                        }
                        else
                        {
                            Data.FirstName = doctor.FirstName;
                            Data.LastName = doctor.LastName;
                            Data.Email = doctor.Email;
                            Data.CellNumber = doctor.CellNumber;
                            Data.UserType = "Doctor";
                        }
                    }
                    else 
                    {
                        Data.FirstName = patient.FirstName;
                        Data.LastName = patient.LastName;
                        Data.Email = patient.Email;
                        Data.CellNumber = patient.CellNumber;
                        Data.UserType = "Patient";


                    }
                 
                 
                  
                   
                }
                else
                {
                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");
                }

               

            }
            return View(Data);
        }

        [HttpGet]
        public IActionResult Detail(int Id)
        {
            


                if (Id <= 0 || User.Identity.Name == null)
                {
                UserDetailModel user = new UserDetailModel();
                var patient = _patientUserModel.GetById(Id);
                    if (patient == null)
                    {
                        var doctor = _doctorUserModel.GetById(Id);
                        if (doctor == null)
                        {
                            var pharmacis = _PharmacistUserModel.GetById(Id);
                            if (pharmacis == null)
                            {
                                var Admin = _AdminUserModel.GetById(Id);
                                if (Admin == null)
                                {
                                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                                    return RedirectToAction("Error", "Account");
                                }
                                else
                                {
                                    user.FirstName = Admin.FirstName;
                                    user.LastName = Admin.LastName;
                                user.Email = Admin.Email;
                                user.CellNumber = Admin.CellNumber;
                                user.UserType = "Admin";
                                }
                            }
                            else
                            {
                            user.FirstName = pharmacis.FirstName;
                            user.LastName = pharmacis.LastName;
                            user.Email = pharmacis.Email;
                            user.CellNumber = pharmacis.CellNumber;
                            user.UserType = "Pharmacist";
                            user.PharmacistRegNumber = pharmacis.PharmacistRegNumber;
                            }
                        }
                        else
                        {
                        user.FirstName = doctor.FirstName;
                        user.LastName = doctor.LastName;
                        user.Email = doctor.Email;
                        user.CellNumber = doctor.CellNumber;
                        user.HelthCouncilRegNumber = doctor.HelthCouncilRegNumber;
                        user.UserType = "Doctor";
                        }
                    }
                    else
                    {
                    user.FirstName = patient.FirstName;
                    user.LastName = patient.LastName;
                    user.Email = patient.Email;
                    user.CellNumber = patient.CellNumber;
                    user.UserType = "Patient";
                    user.HasVistedDoctor = patient.HasVistedDoctor;
                    }
                     return View(user);
                 }
                else
                {
                    TempData["Error"] = "Somthing Went Wrong Please Try Again";
                    return RedirectToAction("Error", "Account");
                }
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register()
        {
            ViewBag.ProvinceId = new SelectList(_provinceModel.GetAll(), "ProvinceId", "ProvinceName");
            ViewBag.GanderId = new SelectList(_ganderModel.GetAll(), "GanderId", "GanderName");
            return View();
        }
        private string HelthCouncilRegNumber()
        {
            const string letter = "123456789";
            StringBuilder res = new StringBuilder();
            int z = 12;
            Random rndm = new Random();
            while (0 < z--)
            {
                res.Append(letter[rndm.Next(letter.Length)]);
            }
            return "HCREG-"+res.ToString();
        }
        private string PharmacistRegNumber()
        {
            const string letter = "123456789";
            StringBuilder res = new StringBuilder();
            int z = 12;
            Random rndm = new Random();
            while (0 < z--)
            {
                res.Append(letter[rndm.Next(letter.Length)]);
            }
            return "REG-" + res.ToString();
        }
        
       
        private string Password()
        {
            const string letter = "0M0NB5V4CX9ZA1B2C3D5F4G7H8J9L6PIUYTREWQ";
            StringBuilder res = new StringBuilder();
            int z = 6;
            Random rndm = new Random();
            while (0 < z--)
            {
                res.Append(letter[rndm.Next(letter.Length)]);
            }
            return res.ToString();
        }
        public async Task ConfirmEmail_Token(UserModel userModel)
        {
            var token = await _userManager.GenerateEmailConfirmationTokenAsync(userModel);
            var confirmationLink = Url.Action("ConfirmEmail", "Account", new { UserId = userModel.Id, token }, Request.Scheme);
            SendEmail(userModel.Email, confirmationLink);
        }
       
        public JsonResult GetCityById(int Id)
        {
            SelectList Data = new SelectList(_cityModel.GetAllByProvimce(Id), "CityId", "CityName");
            return Json(Data);
        }

        
       
       [HttpGet]
        public IActionResult RegisterDoctor()
        {
            ViewBag.MedicalPrectiseId = new SelectList(_medicalPrectiseModel.GetAll(), "MedicalPrectiseId", "MedicalPrectiseName");
            ViewBag.DoctorSpecializationId = new SelectList(_doctorSpecializationModel.GetAll(), "DoctorSpecializationId", "DoctorSpecializationName");
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> RegisterDoctor(DoctorRegisterModel Model)
        {
            if (ModelState.IsValid)
            {
                var UserModel = new UserModel { UserName = Model.Email, Email = Model.Email, RegTime = DateTime.Now };
                var RegUser = await _userManager.CreateAsync(UserModel, Password());
                if (RegUser.Succeeded)
                {
                    await ConfirmEmail_Token(UserModel);
                    if (await _userManager.IsInRoleAsync(await _userManager.FindByNameAsync(User.Identity.Name), "Admin"))
                    {
                            DoctorUserModel Doctor = new DoctorUserModel();
                            Doctor.Statuse = true;
                            Doctor.Email = Model.Email;
                            Doctor.HelthCouncilRegNumber = HelthCouncilRegNumber();
                            Doctor.CellNumber = Model.CellNumber;
                            Doctor.FirstName = Model.FirstName;
                            Doctor.LastName = Model.LastName;
                            Doctor.Id = UserModel.Id;
                            Doctor.MedicalPrectiseId = Model.MedicalPrectiseId;
                            Doctor.DoctorSpecializationId = Model.DoctorSpecializationId;

                            try
                            {
                                await _userManager.AddToRoleAsync(UserModel, "Doctor");
                                _doctorUserModel.Add(Doctor);
                            }
                            catch
                            {
                                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                                return RedirectToAction("Error", "Account");
                            }
                            TempData["Succeeded"] = "Doctor was registered Succesfully ,Email Verification Was Sent To Your Email Address";
                            return RedirectToAction("Succeeded", "Account");                       
                    }
                }
                foreach (var error in RegUser.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            ViewBag.MedicalPrectiseId = new SelectList(_medicalPrectiseModel.GetAll(), "MedicalPrectiseId", "MedicalPrectiseName");
            ViewBag.DoctorSpecializationId = new SelectList(_doctorSpecializationModel.GetAll(), "DoctorSpecializationId", "DoctorSpecializationName");
            return View(Model);
        }
        public IActionResult RegisterPharmacist()
        {
            ViewBag.PharmacId = new SelectList(_pharmacModel.GetAll(), "PharmacId", "PharmacName");
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> RegisterPharmacist(PharmacistUserModel Model)
        {
            if(ModelState.IsValid)
            {
                var UserModel = new UserModel { UserName = Model.Email, Email = Model.Email, RegTime = DateTime.Now };
                var RegUser = await _userManager.CreateAsync(UserModel, Password());
                if (RegUser.Succeeded)
                {
                    await ConfirmEmail_Token(UserModel);
                    Model.Statuse = true;
                    Model.PharmacistRegNumber = PharmacistRegNumber();
                    Model.Id = UserModel.Id;
               
                    try
                    {
                        await _userManager.AddToRoleAsync(UserModel, "Pharmasist");
                        _PharmacistUserModel.Add(Model);
                    }
                    catch
                    {
                        TempData["Error"] = "Somthing Went Wrong Please Try Again";
                        return RedirectToAction("Error", "Account");
                    }
                    TempData["Succeeded"] = "Pharmacist was registered Succesfully ,Email Verification Was Sent To Your Email Address";
                    return RedirectToAction("Succeeded", "Account");
                }
            }
            ViewBag.PharmacId = new SelectList(_pharmacModel.GetAll(), "PharmacId", "PharmacName");
            return View(Model);
        }
        public IActionResult RegisterAdmin()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> RegisterAdmin(AdminUserModel Model)
        {
            if (ModelState.IsValid)
            {
                var UserModel = new UserModel { UserName = Model.Email, Email = Model.Email, RegTime = DateTime.Now };
                var RegUser = await _userManager.CreateAsync(UserModel, Password());
                if (RegUser.Succeeded)
                {
                    await ConfirmEmail_Token(UserModel);
                    Model.Statuse = true;
                    Model.Id = UserModel.Id;
                    try
                    {
                        await _userManager.AddToRoleAsync(UserModel, "Admin");
                        _AdminUserModel.Add(Model);
                    }
                    catch
                    {
                        TempData["Error"] = "Somthing Went Wrong Please Try Again";
                        return RedirectToAction("Error", "Account");
                    }
                    TempData["Succeeded"] = "Admin was registered Succesfully ,Email Verification Was Sent To Your Email Address";
                    return RedirectToAction("Succeeded", "Account");
                }
            }
            return View(Model);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Register(RegisterUserModel Model)
        {
            if (ModelState.IsValid)
            {
                if (_patientUserModel.GetByIdentityNo(Model.IdendityNumber) != null)
                {
                    ViewBag.Id = "Identity Number  " + Model.IdendityNumber + "  You provided Is already in use";
                    return View(Model);
                }
                var UserModel = new UserModel { UserName = Model.Email, Email = Model.Email, RegTime = DateTime.Now };
                var RegUser = await _userManager.CreateAsync(UserModel, Model.Password);
                if (RegUser.Succeeded)
                {
                    await ConfirmEmail_Token(UserModel);

                        PatientUserModel patient = new PatientUserModel();
                        patient.Statuse = true;
                        patient.Email = Model.Email;
                        patient.HasVistedDoctor = false;
                        patient.CellNumber = Model.CellNumber;
                        patient.FirstName = Model.FirstName;
                        patient.LastName = Model.LastName;
                        patient.Id = UserModel.Id;
                    patient.IdendityNumber = Model.IdendityNumber;
                      patient.GanderId = Model.GanderId;
                    patient.CityId = 1;
                    patient.AddressLine1 = Model.AddressLine1;
                    patient.AddressLine2 = Model.AddressLine2;
                    patient.SuburbName = Model.SuburbName;
                    patient.PostCode = Model.PostCode;
                        try
                        {
                            await _userManager.AddToRoleAsync(UserModel, "Patient");
                            _patientUserModel.Add(patient);
                        }
                        catch
                        {
                            TempData["Error"] = "Somthing Went Wrong Please Try Again";
                            return RedirectToAction("Error", "Account");
                        }
                    
                   
                    TempData["Succeeded"] = "Email Verification Was Sent To Your Email Address";
                    return RedirectToAction("Succeeded", "Account");
                }
                foreach (var error in RegUser.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            ViewBag.ProvinceId = new SelectList(_provinceModel.GetAll(), "ProvinceId", "ProvinceName");
            ViewBag.GanderId = new SelectList(_ganderModel.GetAll(), "GanderId", "GanderName");
            return View(Model);
        }
        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> EmailIsInUsE(string email)
        {
            var Find_User = await _userManager.FindByEmailAsync(email);

            if (Find_User == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Email {email} is already in use");
            }
        }
        [AcceptVerbs("Get", "Post")]
        [AllowAnonymous]
        public async Task<IActionResult> IdentityNoIsInUsE(string email)
        {
            var Find_User = await _userManager.FindByEmailAsync(email);

            if (Find_User == null)
            {
                return Json(true);
            }
            else
            {
                return Json($"Identity Number  {email}  is already in use, Contact Admin");
            }
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginModel Model, string ReturnUrl)
        {
            if (ModelState.IsValid)
            {
                var Validate_User = await _signInManager.PasswordSignInAsync(Model.Email, Model.Password, true, false);
                if (Validate_User.Succeeded)
                {
                    if (!string.IsNullOrEmpty(ReturnUrl) && Url.IsLocalUrl(ReturnUrl))
                    {

                        return Redirect(ReturnUrl);
                    }

                    return RedirectToAction("Welcome", "Account");
                }

                ModelState.AddModelError(string.Empty, "Login Failed ... Invalid Email or Password Provided");

            }
            return View(Model);
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult ForgortPassword()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> ForgotPasswordReset(string Email, string token)
        {
            if (Email == null || token == null)
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            var Find_User = await _userManager.FindByEmailAsync(Email);
            if (Find_User == null)
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            else
            {
                ForgotPasswordResetViewModel data = new ForgotPasswordResetViewModel();
                data.Email = Email;
                data.token = token;
                return View(data);
            }

        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> ForgotPasswordReset(ForgotPasswordResetViewModel data)
        {
            if (data.Email == null || data.token == null)
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            var Find_User = await _userManager.FindByEmailAsync(data.Email);
            if (Find_User == null)
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            var ResetPassword = await _userManager.ResetPasswordAsync(Find_User, data.token, data.Password);

            if (ResetPassword.Succeeded)
            {
                await _signInManager.SignInAsync(Find_User, isPersistent: true);

                await _signInManager.SignOutAsync();
                TempData["Succeeded"] = "The Password Was Changed Succesfull";
                return RedirectToAction("Succeeded", "Account");
            }
            else
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }

        }
        [AllowAnonymous]
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ForgortPassword(ForgotPasswordModel model)
        {
            if (ModelState.IsValid)
            {

                var FindByEmail = await _userManager.FindByEmailAsync(model.Email);

                if (FindByEmail != null && await _userManager.IsEmailConfirmedAsync(FindByEmail))
                {
                    var token = await _userManager.GeneratePasswordResetTokenAsync(FindByEmail);
                    var passwordRestLink = Url.Action("ForgotPasswordReset", "Account", new { email = model.Email, token }, Request.Scheme, Request.Host.ToString());
                    SendEmail(model.Email, passwordRestLink);
                    TempData["Succeeded"] = "The Password Reset Link Was Sent To Your Email Address";
                    return RedirectToAction("Succeeded", "Account");
                }
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            return View(model);
        }
        [AllowAnonymous]
        public  void SendEmail(string? To, string? confirmationLink)
        {

            string Subject = "E-Prescription Email Confimation";
            MailMessage Mail = new MailMessage();
            Mail.To.Add(To);
            Mail.Subject = Subject;
            Mail.Body = "<p1>Please Confirm your email</p1>" + "<hr/>" + "<a href=" + confirmationLink + ">Confirm</a>";
            Mail.IsBodyHtml = true;
            Mail.From = new MailAddress("noreplay.eprescription@gmail.com");
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.Port = 587;
            smtp.UseDefaultCredentials = false;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("noreplay.eprescription@gmail.com", "rfqjhujrdlktdtka");
           smtp.SendMailAsync(Mail);

        }
        [AllowAnonymous]
        [AcceptVerbs("Get", "Post")]

        public async Task<IActionResult> ConfirmEmail(string UserId, string token)
        {
            if (UserId == null || token == null)
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");

            }
            var Find_Use = await _userManager.FindByIdAsync(UserId);
            if (Find_Use == null)
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }
            var Confirm_Email = await _userManager.ConfirmEmailAsync(Find_Use, token);
            if (Confirm_Email.Succeeded)
            {
                await _signInManager.SignInAsync(Find_Use, isPersistent: true);

                await _signInManager.SignOutAsync();
                TempData["Succeeded"] = "Your Email Was Confirm Succesfull";
                return RedirectToAction("Succeeded", "Account");
            }
            else
            {
                TempData["Error"] = "Somthing Went Wrong Please Try Again";
                return RedirectToAction("Error", "Account");
            }

        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Succeeded()
        {
            if (TempData["Succeeded"] != null)
            {
                ViewBag.success = TempData["Succeeded"];
                TempData.Clear();
            }
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
                TempData.Clear();
            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public IActionResult Error()
        {
            if (TempData["Error"] != null)
            {
                ViewBag.Error = TempData["Error"];
                TempData.Clear();
            }
            return View();
        }


    }
}