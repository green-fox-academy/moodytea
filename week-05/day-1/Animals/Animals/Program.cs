using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    class Program
    {
        static void Main(string[] args)
        {
            var reptile = new Reptile("Crocodile");
            var mammal = new Mammal("Koala");
            var bird = new Bird("Parrot");

            Console.WriteLine("Who wants a baby?");
            Console.WriteLine(reptile.GetName() + ", " + reptile.WantsChild());
            Console.WriteLine(mammal.GetName() + ", " + mammal.WantsChild());
            Console.WriteLine(bird.GetName() + ", " + bird.WantsChild());
            Console.ReadKey();
        }
    }
}
