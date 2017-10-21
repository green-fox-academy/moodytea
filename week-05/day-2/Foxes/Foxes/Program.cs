using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foxes
{
    class Program
    {
        static void Main(string[] args)
        {
            var foxes = new List<Fox>();
            foxes.Add(new Fox("Vuk", "alpaga", "green"));
            foxes.Add(new Fox("Roka", "alpaga", "brown"));
            foxes.Add(new Fox("NemSzimba", "pallida", "multicolor"));
            foxes.Add(new Fox("Kitsune", "pallida", "green"));
            foxes.Add(new Fox("Foxie", "oracle", "neonpink"));

            var findFox2 = from i in foxes
                           where i.Color.Equals("green") && i.Type.Equals("pallida")
                           select i.Name;


            foreach (var i in foxes.Where(i => i.Color.Equals("green") && i.Type.Equals("pallida")).Select(i =>i.Name))
            {
                Console.WriteLine(i);
            }
        }
    }
}
