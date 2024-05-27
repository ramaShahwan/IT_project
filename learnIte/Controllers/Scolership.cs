using ITE_Project.Dto.Std_Scholarship;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyTables.Entity.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using ITE_Project.Dto.Scholarship;
using ITE_Project.Dto.Stored_ProceduresDto;
using ITE_Project.Dto.University;
using MyDbProject;
using ITE_Project.Repo.My_Exception;
using ITE_Project.Dto.Student;
namespace learnIte.Controllers
{
    [Authorize(Roles = SD.StudentUser)]
    public class ScolershipController : Controller

    {
        private readonly IStudentRepo _repo3;
        private readonly IScholarshipRepo _repo;
        private readonly IStd_ScholarshipRepo _repo2;
        private readonly IUniversityRepo _Urepo;
        private readonly IStored_ProceduresRepo _srepo;
        public ScolershipController(IStudentRepo _repo3,IScholarshipRepo _repo, IStd_ScholarshipRepo _repo2, IStored_ProceduresRepo _srepo, IUniversityRepo _Urepo)
        {
            this._repo = _repo;
            this._repo2 = _repo2;
            this._repo3 = _repo3;
            this._srepo = _srepo;
            this._Urepo = _Urepo;
        }


        public IActionResult Index()
        {
            var claimsidentity = (ClaimsIdentity)User.Identity;
            var claims = claimsidentity.FindFirst(ClaimTypes.Email);
            string userid = claims.Value;

            ViewData["Student"] = _repo3.GetStudentByEmail(userid);
            return View(_repo.GetAllSholarships());
        }
        [Authorize(Roles = SD.StudentUser)]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult AddToUser(int id)
        {
            var claimsidentity = (ClaimsIdentity)User.Identity;
            var claims = claimsidentity.FindFirst(ClaimTypes.Email);
            string userid = claims.Value;
           
            AddStd_ScholarshipDto AddToUser = _repo2.AddToUser(id, userid);
             bool x=  _repo2.AddStd_Scholarship(AddToUser);
            
              if(x== true)
                {
                    TempData["Success"] = "The Scholarship has been added..";
                    return RedirectToAction("MyScolership", "MyCourses", null);
                }
               
            else
                {

                    TempData["Error"] = "You cannot register for this scholarship either you have already registered or the registration date has expired";
                    return RedirectToAction("MyScolership", "MyCourses", null);
                }
               
              
          

           
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View(); 

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit( StudentDto Dto)
        {
            _repo3.UpdateStudent(Dto);
                TempData["Success"] = "The Student has been Update..";
                return RedirectToAction("Index");
            
        }
        //public IActionResult Details(int id)
        //{
        //    var claimsidentity = (ClaimsIdentity)User.Identity;
        //    var claims = claimsidentity.FindFirst(ClaimTypes.Email);
        //    string userid = claims.Value;
        //    return View();
        //}
        //[Authorize(Roles = SD.StudentUser)]
        //[ValidateAntiForgeryToken]
        //[HttpPost]
        //public IActionResult Details()
        //{

        //    return View();
        //}
        public JsonResult UniversityNameByScholar(int id)
        {
            var res = _srepo.UniversityNameByScholar(id);
            return Json(res);
        }
        public IActionResult SearchScholar(int UniversityId, int Specialize_Name)
        {
            ViewData["Scholarship"] = _srepo.Search_Scholarship_By_Spec_Univer(UniversityId,Specialize_Name);
            var res = _srepo.Search_Scholarship_By_Spec_Univer(UniversityId, Specialize_Name);
            List<ScholarshipDto> Scholarshis = new List<ScholarshipDto>();
            foreach (var item in res)
            {
                ScholarshipDto scholar = new ScholarshipDto();
                scholar.StartDate = item.StartDate;
                scholar.EndDate = item.EndDate;
                scholar.Description = item.Description;
                Scholarshis.Add(scholar);
            }
            return View("Index", Scholarshis);
        }
    }
   
}
