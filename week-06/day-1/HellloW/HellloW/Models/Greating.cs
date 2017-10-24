using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HellloW.Models
{
    public class Greating
    {
        public long ID;
        public static long id;
        public string content;

        public Greating(string name)
        {
            content = "Hello " + name;
            this.ID = id;
        }

    }
}
