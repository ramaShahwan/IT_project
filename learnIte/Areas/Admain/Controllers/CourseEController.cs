using ITE_Project.Dto.Course;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Mvc;
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
    public class CourseEController : Controller
    {
        private readonly ICourseRepo _repo;
        public CourseEController(  ICourseRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAllCourse2());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddCourseDto addDto)
        {
            if (ModelState.IsValid)
            {
                 _repo.AddCourse(addDto);
                TempData["Success"] = "The Course has been added..";
                return RedirectToAction("Index");
            }
            return View(addDto);
        }
        public IActionResult Edit(int id)
        {
            var opiniondto = _repo.GetCourseById(id);
            if (opiniondto == null)
            {
                return NotFound();
            }
            return View(opiniondto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, CourseDto Updatedto)
        {
           
           
            if (ModelState.IsValid)
            {
                _repo.UpdateCourse(Updatedto);
                TempData["Success"] = "The Course has been Update..";
                return RedirectToAction("Index");
            }

            return View(Updatedto);
        }
        [HttpGet]
           public IActionResult Details(int id)
        {
            

            var coursedto = _repo.GetCourseById(id);
           
            return View(coursedto);
        }
        public IActionResult Delet(int id)
        {
           _repo.DeleteCourse(id);
            TempData["Success"] = "The Course has been removed";
            return RedirectToAction("Index");

        }
    }
}
