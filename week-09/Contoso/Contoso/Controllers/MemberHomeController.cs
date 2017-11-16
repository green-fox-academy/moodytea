using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Contoso.Controllers
{
    [Route("[controller]")]
    //[Route("Members")]
    public class MemberHomeController : Controller
    {
        // GET: /<controller>/
        //[Route("")]
        //[Route("Index")]
        [Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("access")]
        public IActionResult AccessGranted()
        {
            return View();
        }
    }
}
