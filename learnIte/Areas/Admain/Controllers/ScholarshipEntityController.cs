using ITE_Project.Dto.Scholarship;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using MyTables.Entity.NewFolder;

namespace learnIte.Areas.Admain.Controllers
{
    [Authorize(Roles = SD.AdmainUser)]
    [Area("Admain")]
    public class ScholarshipEntityController : Controller
    {
        private readonly IScholarshipRepo _repo;
        private readonly IUniversityRepo _repounivercity;
        public ScholarshipEntityController(IScholarshipRepo repo, IUniversityRepo repounivercity)
        {
            _repo = repo;
            _repounivercity = repounivercity;
        }
       
        [HttpGet]
        public IActionResult Index()
        {
            ViewData["university"] = _repounivercity.GetAllUniversities();
            return View(_repo.GetAllSholarships());
        }
        [HttpGet]
        public IActionResult Create()
        {
            var c = _repo.getall();
            return View(c);
        }
        public IActionResult GetScholar(String Fullname)
        {
            var res = _repo.SearchStudentsByName(Fullname);

            return View(res);
        }

        public ActionResult Search(ScholarshipDto s)
        {
            ViewData["university"] = _repounivercity.GetAllUniversities();
            var res = _repo.GetScholarshipByUniversty(s.UniversityId);
            return View("Index", res);
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
       
    }
}
