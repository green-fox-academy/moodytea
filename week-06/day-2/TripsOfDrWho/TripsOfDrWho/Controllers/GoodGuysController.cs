using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripsOfDrWho.Models;

namespace TripsOfDrWho.Controllers
{

    [Route("")]
    public class HomeController : Controller
    {
        static Trips trips1 = new Trips("Eleventh", true, 10100.00);
        static Trips trips2 = new Trips("Missy", false, 1200.00);
        static Trips trips3 = new Trips("Amy", true, 200.00);
        static Trips trips4 = new Trips("Rory", true, 50.00);
        static Trips trips5 = new Trips("DalekLord", false, 5200.00);
        public static List<Trips> trips = new List<Trips> { trips1, trips2, trips3, trips4, trips5 };

        [Route("")]
        [Route("trips")]
        public IActionResult Index(Trips trip1)
        {
            return View(trip1);
        }

    }
}