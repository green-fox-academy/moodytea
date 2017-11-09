using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Groot.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Groot.Controllers
{
    public class GuardianController : Controller
    {
        GrootClass input = new GrootClass();

        [HttpGet]
        [Route("/groot")]
        public IActionResult Index(GrootClass input)
        {
            if (input == null)
            {
                return StatusCode(400, new JsonResult(new { error = "I am Groot!" }));
            }
            else
            {
                return new JsonResult(new { received = input, translated = "I am Groot!" });
            }
        }
    }
}
