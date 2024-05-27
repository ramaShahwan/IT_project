using ITE_Project.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyTables.Entity.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace learnIte.Areas.University.Controllers
{
    [Authorize(Roles = SD.UniversityUser)]
    [Area("University")]
    public class UserMangerController : Controller
    {
        private readonly IStd_ScholarshipRepo _repo;

        public UserMangerController(IStd_ScholarshipRepo repo)
        {
            _repo = repo;

        }
        public IActionResult Index()
        {

            var claimsidentity = (ClaimsIdentity)User.Identity;
            var claims = claimsidentity.FindFirst(ClaimTypes.Email);
            string userid = claims.Value;
            return View(_repo.GetAllStd_Scholarships_for_University(userid));
        }
        public IActionResult Delet(int id)
        {
            _repo.DeleteStd_Scholarship(id);
            TempData["Success"] = "The record of a student who has registered for this scholarship has been cleared";
            return RedirectToAction("Index");

        }
        public IActionResult Lockunlock(int id)
        {
            _repo.TakeStd(id);
            return RedirectToAction("Index");
        }
    }
}
