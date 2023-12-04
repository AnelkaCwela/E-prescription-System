using Project2022.Models.DataBind;
using Project2022.Models.DataModel;
using Project2022.Models.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using System.ComponentModel;

namespace Project2022.Controllers
{
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRoleModel> _RoleManger;
        private readonly UserManager<UserModel> _UserManger;
        private readonly SignInManager<UserModel> _signInManager;
        public AdminController(RoleManager<IdentityRoleModel> RoleManger, UserManager<UserModel> UserManger, SignInManager<UserModel> signInManager)
        {

            this._RoleManger = RoleManger;
            this._UserManger = UserManger;
            this._signInManager = signInManager;

        }
        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]

        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> CreateRole(RoleModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRoleModel identityRole = new IdentityRoleModel
                {
                    Name = model.RoleName
                    ,RoleDescription=model.RoleDescription
                };
                IdentityResult result = await _RoleManger.CreateAsync(identityRole);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRole", "Admin");
                }
                foreach (IdentityError err in result.Errors)
                {
                    ModelState.AddModelError("", err.Description);
                }

            }

            return View(model);
        }

        [HttpGet]
        public IActionResult ListRole()
        {
            var role = _RoleManger.Roles;

            return View(role);
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(int Id)
        {
            var role = await _RoleManger.FindByIdAsync(Id.ToString());
            if (role == null)
            {
                ViewBag.errMessage = $"Role with Id = {Id} cannet be found";
                return View("NotFound");
            }
            var model = new EditRoleModel
            {
                Id = role.Id,
                RoleName = role.Name
                ,RoleDescri=role.RoleDescription 
            };
            foreach (var user in _UserManger.Users)
            {
                if (await _UserManger.IsInRoleAsync(user, role.Name))
                {

                    model.Users.Add(user.UserName);


                }
            }
            return View(model);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> EditRole(EditRoleModel model)
        {
            var role = await _RoleManger.FindByIdAsync(model.Id.ToString());
            if (role == null)
            {
                ViewBag.errMessage = $"Role with Id = {model.Id} cannot be found";
                return View("NotFound");
            }
            else
            {
                role.Name = model.RoleName;
                role.RoleDescription = model.RoleDescri;
                var result = await _RoleManger.UpdateAsync(role);
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRole");
                }
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }


            return View(model);
        }
        [HttpGet]
        public async Task<IActionResult> AddUserToRole(int RoleId)
        {
            ViewBag.RoleId = RoleId;
            var role = await _RoleManger.FindByIdAsync(RoleId.ToString());
            if (role == null)
            {
                ViewBag.errMessage = $"Role with Id = {RoleId} cannet be found";
                return View("NotFound");
            }
            var model = new List<UserRoleViewModel>();
            foreach (var user in _UserManger.Users)
            {

                    var userRoleViewModel = new UserRoleViewModel
                    {
                        UserId = user.Id,
                        UserName = user.UserName
                      

                    };
                    if (await _UserManger.IsInRoleAsync(user, role.Name))
                    {
                        userRoleViewModel.IsSelected = true;
                    }
                    else
                    {
                        userRoleViewModel.IsSelected = false;
                    }
                    model.Add(userRoleViewModel);               
            }
            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> AddUserToRole(List<UserRoleViewModel> model, int RoleId)
        {

            var role = await _RoleManger.FindByIdAsync(RoleId.ToString());
            if (role == null)
            {
                ViewBag.errMessage = $"Role with Id = {model[0].RoleId.ToString()} cannet be found";
                return View("NotFound");
            }
            for (int i = 0; i < model.Count; i++)
            {
                var user = await _UserManger.FindByIdAsync(model[i].UserId.ToString());
                IdentityResult result = null;
                if (model[i].IsSelected && !(await _UserManger.IsInRoleAsync(user, role.Name)))
                {
                    result = await _UserManger.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await _UserManger.IsInRoleAsync(user, role.Name))
                {
                    result = await _UserManger.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }
                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { id = RoleId });
                }
            }
            return RedirectToAction("EditRole", new { id = RoleId });
        }
    }
}
