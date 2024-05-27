using ITE_Project.Dto.Scholarship;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyTables.Entities;
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
    public class ScholarshipMangerController : Controller
    {
        private readonly IScholarshipRepo _repo;
      
        public ScholarshipMangerController(IScholarshipRepo repo)
        {
            _repo = repo;
           
        }
        public IActionResult Index()
        {
            var claimsidentity = (ClaimsIdentity)User.Identity;
            var claims = claimsidentity.FindFirst(ClaimTypes.Email);
            string userid = claims.Value;
            return View(_repo.getScholarship(userid));
        }

        public IActionResult Create()
        {
           
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddScholarshipDto addDto)
        {
            if (ModelState.IsValid)
            {
                _repo.AddScholarship(addDto);
                TempData["Success"] = "The Scholarship has been added..";
                return RedirectToAction("Index");
            }
            return View(addDto);
        }
        public IActionResult Edit(int id)
        {
            var Scholarshipdto = _repo.GetScholarshipByID(id);
            if (Scholarshipdto == null)
            {
                return NotFound();
            }


            return View(Scholarshipdto);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ScholarshipDto Updatedto)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateScholarship(Updatedto);
                TempData["Success"] = "The Scholarship has been Update..";
                return RedirectToAction("Index");
            }

            return View(Updatedto);
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var scholarshipdto = _repo.GetScholarshipByID(id);

            return View(scholarshipdto);
        }
        public IActionResult Delet(int id)
        {
            _repo.DeleteScholarship(id);
            TempData["Success"] = "The Scholarship has been removed";
            return RedirectToAction("Index");

        }

        //[HttpGet]
        //public IActionResult Create()
        //{
        //    ViewData["UniversityId"] = _repounivercity.GetAllUniversities();
        //    return View(/*_repo.AddScholarshipWithList()*/);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public IActionResult Create(AddScholarshipDto addDto)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _repo.AddScholarship(addDto);
        //        TempData["Success"] = "The Scholarship has been added..";
        //        return RedirectToAction("Index");
        //    }
        //    return View(addDto);
        //}
    }
}
