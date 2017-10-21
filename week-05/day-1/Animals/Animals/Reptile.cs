using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Reptile : Animal
    {
        public Reptile(string name)
        {
            Name = name;
            Age = 3;
            Child = "egg";
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
