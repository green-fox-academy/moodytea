using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApp.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        public string what { get; private set; }
        public int [] numbers { get; private set; }

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
        [Route("/greeter")]
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

        [HttpPost]
        [Route("/dountil/sum")]
        public JsonResult Sum(int input)
        {
            int i = 0;
            do
            {
                input += input;
                i++;
            } while (i != input);

            if (input != 0)
            {
                return Json(new { until = $"{input}" });
            }
            else
            {
                return Json(new { error = "Please provide a number!" });
            }
        }

        [HttpPost]
        [Route("/dountil/factor")]
        public JsonResult Factor(int input)
        {
            int i = 0;
            do
            {
                input *= input;
                i++;
            } while (i != input);

            if (input != 0)
            {
                return Json(new { until = $"{input}" });
            }
            else
            {
                return Json(new { error = "Please provide a number!" });
            }


        }

        [HttpPost]
        [Route("/arrays")]
        public JsonResult Arrays(JsonNumbers json)
        {
            int number = 0;
            int i = 0;
            int[] number2 = new int[numbers.Length] { };

            if (what == "sum")
            {
                do
                {
                    number += numbers[i];
                    i++;
                } while (i != numbers.Length);
                return Json(new { until = number });
            }
            else if (what == "multiply")
            {
                do
                {
                    number *= numbers[i];
                    i++;
                } while (i != numbers.Length);
                return Json(new { until = number });
            }
            else if (what == "double")
            {
                do
                {
                    number2[i] = numbers[i]*2;
                    i++;
                } while (i != numbers.Length);
                return Json(new { until = number2 });
            }
            else
            {
                return Json(new { error = "Please provide what to do with the numbers!" });
            }
        }
    }
}
