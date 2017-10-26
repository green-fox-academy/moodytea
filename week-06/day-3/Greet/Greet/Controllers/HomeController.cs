using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Greet.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Greet.Controllers
{
    public class HomeController : Controller
    {
        Greeting greet;

        public HomeController(Greeting greet)
        {
            this.greet = greet;
        }

        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return View(greet);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Greets(Greeting greet)
        {
            return RedirectToAction("Greet", greet);
        }

        [HttpGet]
        [Route("greet")]
        public IActionResult Greet(Greeting greet)
        {
            return View(greet);
        }
    }
}
