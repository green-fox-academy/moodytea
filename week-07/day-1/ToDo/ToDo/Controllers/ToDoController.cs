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
            return View(list.OrderByDescending(i => i.Votes).ToList());
        }


        [HttpGet]
        [Route("adding")]
        public IActionResult Adding()
        {
            return View(list);
        }

        [HttpPost]
        [Route("adding")]
        public IActionResult Adding(ToDoClass toDoClass)
        {
            toDoContext.Adding(toDoClass);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("delete")]
        public IActionResult Delete(int ID)
        {
            ToDoClass toDoClass = toDoContext.ToDos.Find(ID);
            toDoContext.Deleting(toDoClass);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("upvote")]
        public IActionResult UpVote(int ID)
        {
            toDoContext.UpVoting(ID);
            return RedirectToAction("Index");
        }

        [HttpPost]
        [Route("downvote")]
        public IActionResult DownVote(int ID)
        {
            toDoContext.DownVoting(ID);
            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("edit")]
        public IActionResult Edit()
        {
            return View(list);
        }

        [HttpPost]
        [Route("edit")]
        public IActionResult Edit(ToDoClass toDoClass)
        {
            toDoContext.Deleting(toDoClass);
            return RedirectToAction("Index");
        }
    }
}
