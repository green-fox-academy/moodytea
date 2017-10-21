using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Bird : Animal
    {

        public Bird(string name)
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
