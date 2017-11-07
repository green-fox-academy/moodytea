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
        UntilClass until = new UntilClass();

        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Route("/doubling")]
        public JsonResult Doubling(int input)
        {
            if (input != 0)
            {
                return Json(new { received = input, result = input * 2 });
            }
            else
            {
                return Json(new { error = "Please provide an input!" });
            }
        }

        [HttpGet]
        [Route("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name != null && title != null)
            {
                return Json(new { welcome_message = $"Oh, hi there {name}, my dear {title}!" });
            }
            else if (name != null)
            {
                return Json(new { error = "Please provide a title!" });
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
            return Json(new { appended = $"{appendable}a" });
        }

        [Route("/appenda")]
        public IActionResult AppendA()
        {
            return NotFound();
        }

        //[HttpPost]
        //[Route("/dountil/sum")]
        //public JsonResult Sum([FromBody]int until)
        //{
        //    int i = 0;
        //    int until2 = 0;
        //    do
        //    {
        //        until2 += until-i;
        //        i++;
        //    } while (i != 0);

        //    return Json(new { result = $"{until2}" });

        //}

        [HttpPost]
        [Route("/dountil")]
        [Route("/dountil/{what}")]
        public IActionResult Factor(string what, [FromBody] UntilClass until)
        {
            int i = 0;
            int until2 = 1;
            if (until != null)
            {
                if (what == "factor" && until.Until!= 0)
                {
                    do
                    {
                        until2 *= (until.Until) - i;
                        i++;
                    } while (i != until.Until);
                    return Json(new { result = until2 });
                }
                else if (what == "sum" && until.Until != 0)
                {
                    do
                    {
                        until2 += (until.Until) - i;
                        i++;
                    } while (i != until.Until);
                    return Json(new { result = until2 - 1 });
                }
                else
                {
                    return NotFound();
                }
            }
            else
            {
                return Json(new { error = "Please provide a number!" });
                
            }
        }

        //[HttpPost]
        //[Route("/dountil/factor")]
        //[Route("/dountil/sum")]
        //public JsonResult Factor3()
        //{
        //    return Json(new { error = "Please provide a number!" });
        //}

        //[HttpPost]
        //[Route("/dountil")]
        //public IActionResult Factor2()
        //{
        //    return NotFound();
        //}

        //[HttpPost]
        //[Route("/arrays")]
        //public JsonResult Arrays(JsonNumbers json)
        //{
        //    int number = 0;
        //    int i = 0;
        //    int[] number2 = new int[numbers.Length];

        //    if (what == "sum")
        //    {
        //        do
        //        {
        //            number += numbers[i];
        //            i++;
        //        } while (i != numbers.Length);
        //        return Json(new { until = number });
        //    }
        //    else if (what == "multiply")
        //    {
        //        do
        //        {
        //            number *= numbers[i];
        //            i++;
        //        } while (i != numbers.Length);
        //        return Json(new { until = number });
        //    }
        //    else if (what == "double")
        //    {
        //        do
        //        {
        //            number2[i] = numbers[i] * 2;
        //            i++;
        //        } while (i != numbers.Length);
        //        return Json(new { until = number2 });
        //    }
        //    else
        //    {
        //        return Json(new { error = "Please provide what to do with the numbers!" });
        //    }
        //}

        //[HttpPost]
        //[Route("/dountil/factor")]
        //public JsonResult Log(Log log)
        //{

        //}

    }
}
