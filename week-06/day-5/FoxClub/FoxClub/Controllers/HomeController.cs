﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FoxClub.Models;

namespace FoxClub.Controllers
{
    public class HomeController : Controller
    {
        private Fox fox;

        public HomeController(Fox fox)
        {
            this.fox = fox;
        }

        [HttpGet]
        [Route("")]
        public IActionResult New()
        {
            return View(fox);
        }

        [HttpPost]
        [Route("")]
        public IActionResult Post(string name)
        {
            this.fox.Name = name;
            return RedirectToAction("Information");
        }

        [HttpGet]
        [Route("/information")]
        public IActionResult Information()
        {
            return View(fox);
        }

        [HttpGet]
        [Route("/information/nutritionstore")]
        public IActionResult NutritionStore()
        {
            return View(fox);
        }

        [HttpGet]
        [Route("/information/trickclasses")]
        public IActionResult TrickClasses()
        {
            return View(fox);
        }
    }
}
