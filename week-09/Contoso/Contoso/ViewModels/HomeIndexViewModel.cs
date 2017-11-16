using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contoso.Models;

namespace Contoso.ViewModels
{
    public class HomeIndexViewModel
    {
        public Contact Contact { get; set; }
        public Customer Customer  { get; set; }
    }
}
