using ITE_Project.Dto.Learn_Track;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using MyTables.Entity.NewFolder;
using ITE_Project.Dto.Stored_ProceduresDto;

namespace learnIte.Areas.Admain.Controllers
{
    [Authorize(Roles = SD.AdmainUser)]
    [Area("Admain")]
    public class LearnTrackEntitesController : Controller
    {
        private readonly ILearn_TrackRepo _repo;
        private readonly IStored_ProceduresRepo _irepo;
        public LearnTrackEntitesController(ILearn_TrackRepo repo , IStored_ProceduresRepo irepo)
        {
            _irepo = irepo;
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAllLearn_Track());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddLearn_TrackDto addDto)
        {
            if (ModelState.IsValid)
            {
                _repo.AddLearn_Track(addDto);
                TempData["Success"] = "The Learn Track has been added..";
                return RedirectToAction("Index");
            }
            return View(addDto);
        }
        public IActionResult Edit(int id)
        {

            var opiniondto = _repo.GetLearn_TracktById(id);
            if (opiniondto == null)
            {
                return NotFound();
            }
            return View(opiniondto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Learn_TrackDto Updatedto)
        {
            if (id != Updatedto.LearnTrackId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _repo.UpdateLearn_Track(Updatedto);
                TempData["Success"] = "The Learn Track has been Update..";
                return RedirectToAction("Index");
            }

            return View(Updatedto);
        }
        [HttpGet]
        public IActionResult Details(int id)
        {

            var coursedto = _repo.GetLearn_TracktById(id);
            if (coursedto == null)
            {
                return NotFound();
            }
            return View(coursedto);
        }
        public IActionResult Delet(int id)
        {
        
            _repo.DeleteLearn_Track(id);
            TempData["Success"] = "The Learn Track has been removed";
            return RedirectToAction("Index");

        }


        public IActionResult CountInLearntrack()
        {
            ViewData["LearnTrack"] = _repo.GetAllLearn_Track();
            return View();
        }
        [HttpGet]
        public IActionResult GetCountOfStudentByDate(Count_Of_Student_In_LearnTrack_By_DateDto dto)
        {
            var res = _irepo.Count_Of_Student_In_LearnTrack_By_Date(dto);
            ViewData["LearnTrack"] = _repo.GetAllLearn_Track();
            return View("CountInLearntrack", res);
        }
        public IActionResult CountInSpezialise()
        {
            ViewData["LearnTrack"] = _repo.GetAllLearn_Track();
            return View();
        }
        [HttpGet]
        public IActionResult CountInSpecialiseName(int id)
        {
            var res = _irepo.Count_Of_Student_In_Specialize_Name_Of_LearnTrack(id);
            ViewData["LearnTrack"] = _repo.GetAllLearn_Track();
            return View("CountInSpezialise", res);
        }
        public IActionResult InfoInLearntrack()
        {
            ViewData["LearnTrack"] = _repo.GetAllLearn_Track();
            return View();
        }
        [HttpGet]
        public IActionResult InfoStudInLearntrack(ModelDto dto)
        {
            var res = _irepo.Information_Of_Student_In_LearnTrack_By_Date(dto);
            ViewData["LearnTrack"] = _repo.GetAllLearn_Track();
            return View("InfoInLearntrack", res);
        }
    }
}
