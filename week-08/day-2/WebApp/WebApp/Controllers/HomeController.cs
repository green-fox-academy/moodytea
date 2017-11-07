using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        [Route ("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/doubling")]
        public JsonResult Doubling(int input)
        {
            if(input!= 0)
            {
                return Json(new { received = input, result = input * 2});
            }
            else
            {
                return Json(new { error = "Please provide an input!" });
            }   
        }

        [HttpGet]
        [Route("/doubling")]
        public JsonResult Greeter(string name, string title)
        {
            if (name != String.Empty && title != String.Empty)
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
            else
            {
                return Json(new { error = "Please provide a name!" });
            }
        }

        [HttpGet]
        [Route("/appenda/{appendable}")]
        public JsonResult AppendA(string appendable)
        {
            if (appendable != String.Empty)
            {
                return Json(new { appended = $"{appendable}a" });
            }
            else
            {
                return Json(new { error = 404 });
            }
        }
    }
}
