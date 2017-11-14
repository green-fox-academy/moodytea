using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAnagram.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebAnagram.Controllers
{
    public class HomeController : Controller
    {
        private Anagram anagram;
       
        public HomeController(Anagram anagram)
        {
            this.anagram = anagram;
        }

        [Route("")]
        [Route("/index")]
        public IActionResult Index()
        {
            return View(anagram);
        }

        [HttpGet]
        [Route("/check")]
        public IActionResult Check()
        {
            return View(anagram);
        }

        [HttpPost]
        [Route("/check")]
        public IActionResult Check(string one, string two)
        {
            one = one.Replace(" ", String.Empty);
            two = two.Replace(" ", String.Empty);
            anagram.AreThey(one, two);
            return RedirectToAction("Result");
        }

        [Route("/result")]
        public IActionResult Result()
        {
            return View(anagram);
        }
    }
}
