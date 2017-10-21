using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Mammal : Animal
    {
        public Mammal(string name)
        {
            Name = name;
            Age = 3;
            Child = "embryo";
        }

        public override string GetName()
        {
            return Name;
        }

        public override string WantsChild()
        {
            return $"wants a baby from a/n {Child}";
        }
    }
}
