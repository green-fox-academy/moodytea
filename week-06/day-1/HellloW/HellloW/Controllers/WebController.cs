using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HellloW.Models;

namespace HellloW.Controllers
{

    [Route("web")]
    public class WebController : Controller
    {
        public static long id;
        //public string name;
        [Route("greeting")]
        
        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting(name)
            {
                content = $"{name} this site has been loaded {id++} times"
            };

            return View(greeting);
        }

    }
}
