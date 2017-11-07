using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class Log
    {
        public DateTime createdAt { get; set; }
        public string endpoint { get; set; }
        public string data { get; set; }
    }
}
