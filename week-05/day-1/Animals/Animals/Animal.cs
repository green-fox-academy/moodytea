using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {
        protected string Name { get; set; }
        protected string Child { get; set; }
        protected int Age { get; set; }
        public abstract string GetName();
        public abstract string WantsChild();
    }
}
