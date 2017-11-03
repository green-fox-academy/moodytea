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
        List<ToDo.Models.ToDoClass> list;

        public ToDoController(ToDoContext toDoContext)
        {
            this.toDoContext = toDoContext;
            list = toDoContext.ToDos.ToList();
        }

        [Route("")]
        [Route("list")]
        public IActionResult Index()
        {
            return View(list);
        }

        [Route("new")]
        public IActionResult New()
        {
            return View(list);
        }
    }
}
