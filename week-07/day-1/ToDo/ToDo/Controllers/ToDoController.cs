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
        public ToDoContext toDoContext;



        [Route("")]
        [Route("list")]
        public IActionResult Index()
        {
            return View(toDoContext.ToDos.ToList());
        }
    }
}
