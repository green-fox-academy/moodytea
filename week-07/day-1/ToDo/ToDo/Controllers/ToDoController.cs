using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDo.Models;
using ToDo.Repositories;
using ToDo.Entities;

namespace ToDo.Controllers
{
    [Route("todo")]
    public class ToDoController : Controller
    {
        private ToDoContext toDoContext;
        List<ToDoClass> list;

        public ToDoController(ToDoContext toDoContext)
        {
            this.toDoContext = toDoContext;
            list = toDoContext.ToDos.ToList();
        }

        [HttpGet]
        [Route("")]
        [Route("list")]
        public IActionResult Index()
        {
            return View(list);
        }


        //[HttpGet]
        //[Route("adding")]
        //public IActionResult Adding()
        //{
        //    return View(list);
        //}

        //[HttpPost]
        [Route("adding")]
        public IActionResult Adding(ToDoClass toDoClass)
        {
            toDoContext.Adding(toDoClass);
            return View(list);
        }
    }
}
