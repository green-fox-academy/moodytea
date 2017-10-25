using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CiaoAdios.Model;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CiaoAdios.Controllers
{
    [Route("web")]
    public class WebController : Controller
    {
        [Route("greeting")]

        public IActionResult Greeting(string name)
        {
            var greeting = new Greeting(name)
            {
                
            };

            return View(greeting);
        }

    }
}
