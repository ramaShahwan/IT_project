using ITE_Project.IRepo;
using Microsoft.AspNetCore.Authorization;
using MyTables.Entity.NewFolder;

using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyTables.Entities;
using ITE_Project.Dto.User;

namespace learnIte.Areas.Admain.Controllers
{    [Authorize(Roles =SD.AdmainUser)]
    [Area("Admain")]
    public class UserEntityController : Controller
    {
        private readonly IUserRepo _repo;
        private readonly UserManager<UserEntity> _userManager;
        public UserEntityController(IUserRepo repo, UserManager<UserEntity> userManager)
        {
            _repo = repo;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var claimsidentity = (ClaimsIdentity)User.Identity;
            var claims = claimsidentity.FindFirst(ClaimTypes.Email);
            string userid = claims.Value;
            return View(_repo.GetAllUsers(userid));
        }
        //[HttpGet]
        //public IActionResult Edit(int id)
        //{
        //    var userdto = _repo.GetUserByID(id);
        //    if (userdto == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(userdto);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Edit(int id, UserDto userDto)
        //{
        //    if (id != userDto.Id)
        //    {
        //        return NotFound();
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        _repo.UpdateUser(userDto);
        //        TempData["Success"] = "The User has been Update..";
        //        return RedirectToAction("Index");
        //    }

        //    return View(userDto);
        //}
        public IActionResult Lockunlock (int id )
        {
            _repo.lockuser(id);
            return RedirectToAction("Index");
        }
        public IActionResult Delet(int id)
        {
             _repo.DeleteUser(id);
            TempData["Success"] = "The User has been removed";
            return RedirectToAction("Index");

        }
    }
}
