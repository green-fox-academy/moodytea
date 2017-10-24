using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HellloW.Models
{
    public class Greeting
    {
        public long ID;
        public static long id;
        public string content;

        public Greeting(string name)
        {
            content = "Hello " + name;
            this.ID = id;
        }

        public Greeting()
        {
            this.content = null;
        }
    }
}
