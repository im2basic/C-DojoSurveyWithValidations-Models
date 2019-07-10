using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DojoSurveyIII.Models;

namespace DojoSurveyIII.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("result")]
        public IActionResult Result(MyModel Survey)
        {
            if(ModelState.IsValid)
            {
                return View("Info", Survey);
            }
            else
            {
                return View("Index");
            }
        }




    }
}
