using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HellloW.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HellloW.Controllers
{
    [Route("api")]
    public class RESTController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        [Route("greeting")]
        public IActionResult Greeting2 (string name)
        {
            Greeting.id += 1;
            return new JsonResult(new Greeting(name));
        }

    }
}
