using ITE_Project.Dto.Student;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MyTables.Entity.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learnIte.Areas.Admain.Controllers
{
    [Authorize(Roles = SD.AdmainUser)]
    [Area("Admain")]
    public class StudentEntityController : Controller
    {
        private readonly IStudentRepo _repo;
        public StudentEntityController(IStudentRepo repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAllStudents());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddStudentDto addDto)
        {
            if (ModelState.IsValid)
            {
                _repo.AddStudent(addDto);
                TempData["Success"] = "The Student has been added..";
                return RedirectToAction("Index");
            }
            return View(addDto);
        }
        public IActionResult Edit(int id)
        {
            var studentdto = _repo.GetStudentByID(id);
            if (studentdto == null)
            {
                return NotFound();
            }
            return View(studentdto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, StudentDto Updatedto)
        {


            if (ModelState.IsValid)
            {
                _repo.UpdateStudent(Updatedto);
                TempData["Success"] = "The Student has been Update..";
                return RedirectToAction("Index");
            }

            return View(Updatedto);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
           var studentdto = _repo.GetStudentByID(id);

            return View(studentdto);
        }
        public IActionResult Delet(int id)
        {


            _repo.DeleteStudent(id);
            TempData["Success"] = "The Student has been removed";
            return RedirectToAction("Index");

        }
    }
}
