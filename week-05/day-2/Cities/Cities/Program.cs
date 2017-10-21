using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cities
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            IEnumerable<string> sCities =
                from i in cities
                where i.StartsWith("A") && i.EndsWith("I")
                select i;
            foreach (var item in sCities)
            {
                Console.WriteLine(item);
            }

            string[] sCities2 = cities.Where(x => x.StartsWith("A") && x.EndsWith("I")).ToArray();
            foreach (var item in sCities2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
