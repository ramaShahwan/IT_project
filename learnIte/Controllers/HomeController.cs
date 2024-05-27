using ITE_Project.IRepo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learnIte.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICourseRepo _repo;
        private readonly IOpinionRepo _repo2;

        public HomeController(ICourseRepo repo, IOpinionRepo repo2)
        {
            _repo = repo;
            _repo2 = repo2;
        }
        public IActionResult Index()
        {
            ViewData["Opinio"] = _repo2.GetAllOpinion();
            return View(_repo.GetAllCourse());
        }
    }
}
