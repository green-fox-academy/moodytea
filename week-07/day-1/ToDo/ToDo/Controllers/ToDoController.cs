using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;

namespace ToDo.Controllers
{
    [Route("todo")]
    public class ToDoController : Controller
    {
        

        [Route("")]
        [Route("list")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
