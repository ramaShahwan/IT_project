using ITE_Project.Dto.Student_LT;
using ITE_Project.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace learnIte.Controllers
{
    [Authorize]
    public class LTDatilesController : Controller
    {
        private readonly IStudent_LTRepo _repo;
        private readonly ILearn_TrackRepo _repo2;
        public LTDatilesController(IStudent_LTRepo repo, ILearn_TrackRepo repo2)
        {
            _repo = repo;
            _repo2 = repo2;
        }
       
        public IActionResult Index(int id)
        {
            ViewBag.aa = id;
            ViewData["LearnTrack"] = _repo2.GetLearn_TracktById(id);
           
            return View(_repo.getcourser(id));
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToUser(int id)
        {
            var claimsidentity = (ClaimsIdentity)User.Identity;
            var claims = claimsidentity.FindFirst(ClaimTypes.Email);
            string userid = claims.Value;
         AddStudent_LTDto AddToUser = _repo.AddToUser(id, userid);
          bool x=  _repo.AddStudent_LT(AddToUser);
            if (x==true)
            {
                
                TempData["Success"] = "The track has been added..";
                return RedirectToAction("Index","MyCourses",null);
            }
            else
            {
                TempData["Error"] = "You cannot register on this course because you have already done so";
                return RedirectToAction("Index", "MyCourses", null);

            }
           
        }
    }
}
