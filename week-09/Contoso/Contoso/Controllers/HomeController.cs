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

        // GET: /<controller>/
        [Route("")]
        [Route("Index")]
        [Route("Index/{id}")]
        public IActionResult Index(int id)
        {
            //Response.StatusCode = 404;

            Contact contact = new Contact()
            {
                Id = id,
                FirstName = "Dorothy",
                LastName = "Katona"
            };

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
    }
}
