using ITE_Project.Dto.Opinion;
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
    public class OpinionEntitiesController : Controller
    {
        private readonly IOpinionRepo _repo;
        public OpinionEntitiesController(IOpinionRepo repo)
        {
            _repo = repo;
        }

        public IActionResult Index(int p)
        {

            int pageSize = 5;
           
         var opinion = _repo.GetAllOpinion()
                          .Skip((p - 1) * pageSize)
                          .Take(pageSize);

                ViewBag.PageNumber = p;
                ViewBag.PageRange = pageSize;
                ViewBag.TotalPages = (int)Math.Ceiling((decimal)_repo.GetOpinionCount() / pageSize);
            
          
            return View(opinion.ToList());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AddOpinionDto addDto)
        { _repo.AddOpinion(addDto);
                TempData["Success"] = "The Opinion has been added..";
                return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Edit (int id)
        {
            var opiniondto = _repo.GetOpinionById(id);
            if (opiniondto == null)
            {
                return NotFound();
            }
            return View(opiniondto);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, OpinionDto Updatedto)
        {
            if(id!=Updatedto.OpinionsId)
            {
                return NotFound();
            }
            if(ModelState.IsValid)
            {
                _repo.UpdateOpinion(Updatedto);
                TempData["Success"] = "The Opinion has been Update..";
                return RedirectToAction("Index");
            }
           
            return View(Updatedto);
        }
        [HttpGet]
        public IActionResult Delet(int id)
        {
              _repo.DeleteOpinion(id);
            TempData["Success"] = "The Opinion has been removed";
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Details(int id)
        {
          

            var opiniondto = _repo.GetOpinionById(id);
            if (opiniondto == null)
            {
                return NotFound();
            }
            return View(opiniondto);
        }
    }
}
