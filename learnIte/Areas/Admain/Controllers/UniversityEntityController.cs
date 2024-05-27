using ITE_Project.Dto.University;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learnIte.Areas.Admain.Controllers
{
     [Area("Admain")]
    public class UniversityEntityController : Controller
    {
        private readonly IUniversityRepo _repo;
        private readonly IStored_ProceduresRepo _stored;
        public UniversityEntityController(IUniversityRepo repo, IStored_ProceduresRepo stored)
        {
            _repo = repo;
            _stored = stored;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAllUniversities());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddUniversityDto addDto)
        {
            if (ModelState.IsValid)
            {
                _repo.AddUniversity(addDto);
                TempData["Success"] = "The University has been added..";
                return RedirectToAction("Index");
            }
            return View(addDto);
        }


        public IActionResult Edit(int id)
        {
            var universitydto = _repo.GetUniversityByID(id);
            if (universitydto == null)
            {
                return NotFound();
            }
            return View(universitydto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, UniversityDto Updatedto)
        {
            if (ModelState.IsValid)
            {
                _repo.UpdateUniversity(Updatedto);
                TempData["Success"] = "The University has been Update..";
                return RedirectToAction("Index");
            }

            return View(Updatedto);
        }
        [HttpGet] 
        public IActionResult Details(int id)
        { var universitydto = _repo.GetUniversityByID(id);

            return View(universitydto);
        }
        public IActionResult Delet(int id)
        { _repo.DeleteUniversity(id);
            TempData["Success"] = "The University has been removed";
            return RedirectToAction("Index");

        }
        [HttpGet]
        public IActionResult GetScholarshipByDate()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult GetScholarshipByDate(DateTime StartDate, DateTime EndDate)
        {

            var res = _stored.Count_Of_Student_In_Scholarship_By_Date(StartDate, EndDate);
            return View(res);
        }
    }
}
