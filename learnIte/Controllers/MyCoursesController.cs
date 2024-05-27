using ITE_Project.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyTables.Entity.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace learnIte.Controllers
{
    [Authorize(Roles = SD.StudentUser)]
    public class MyCoursesController : Controller
    {
        private readonly IStudent_LTRepo _repo;
        private readonly IStd_ScholarshipRepo _repo2;

        public MyCoursesController(IStudent_LTRepo repo, IStd_ScholarshipRepo repo2)
        {
            _repo = repo;
            _repo2 = repo2;
        }
        public IActionResult Index()
        {
            var claimsidentity = (ClaimsIdentity)User.Identity;
            var claims = claimsidentity.FindFirst(ClaimTypes.Email);
            string userid = claims.Value;
            return View(_repo.MyLT(userid));
        }
        public IActionResult MyScolership()
        {
            var claimsidentity = (ClaimsIdentity)User.Identity;
            var claims = claimsidentity.FindFirst(ClaimTypes.Email);
            string userid = claims.Value;
            return View(_repo2.MyScholarship(userid));
        }
            public IActionResult Delet(int id)
        {
            _repo.DeleteStudent_LT(id);
            TempData["Success"] = "Registration for this course has been cancelled";
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            _repo2.DeleteStd_Scholarship(id);
            TempData["Success"] = "Registration for this scholarship has been cancelled";
            return RedirectToAction("MyScolership");

        }
    }
}
