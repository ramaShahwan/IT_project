using ITE_Project.Dto.Opinion;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learnIte.Controllers
{

    public class ContactController : Controller
    {
        private readonly IOpinionRepo _repo;
        public ContactController(IOpinionRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(AddOpinionDto addDto)
        {
            if (ModelState.IsValid)
            {

                _repo.AddOpinion(addDto);

                return RedirectToAction("Index", "Home", null);
            }
            return View();
        }
    }
}
