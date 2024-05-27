using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace learnIte.Controllers
{
    public class UniversityController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
