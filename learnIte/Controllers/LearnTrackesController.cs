using ITE_Project.IRepo;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learnIte.Controllers
{
    public class LearnTrackesController : Controller
    {
        private readonly ILearn_TrackRepo _repo;
        private readonly IStored_ProceduresRepo _irepo;
        public LearnTrackesController(ILearn_TrackRepo repo, IStored_ProceduresRepo irepo)
        {
            _repo = repo;
            _irepo = irepo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetAllLearn_Track());
        }
        public IActionResult Search_For_LearnTrack(int id)
        {
            var res =_irepo.Search_For_LearnTrack_By_Specialize_Name(id);
            return View("Index", res);
        }

    }
}
