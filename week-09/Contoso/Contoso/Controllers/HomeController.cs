using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Contoso.Models;
using Contoso.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Contoso.Models
{
    [Route("")]
    [Route("Home")]
    public class HomeController : Controller
    {
        [Route("")]
        //[Route("IndexWithForm")]
        [Route("Index")]
        [Route("Index/{id}")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("IndexWithForm");
        }

        // GET: /<controller>/
        [Route("")]
        [Route("Index")]
        [Route("Index/{id}")]
        [HttpPost]
        public IActionResult Index(/*[FromQuery]*/Contact contact)
        {
            if (ModelState.IsValid)
            {
                Customer customer = new Customer()
                {
                    Id = 2,
                    CustomerName = "The Company"
                };

                HomeIndexViewModel vm = new HomeIndexViewModel()
                {
                    Contact = contact,
                    Customer = customer
                };

                return View(vm);
                //return Content("Hey there sweetie!");
            }
            //Response.StatusCode = 404;

            //Contact contact = new Contact()
            //{
            //    Id = id,
            //    FirstName = "Dorothy",
            //    LastName = "Katona"
            //};

            return View("IndexWithForm");
        }
    }
}
