using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquaredIsBiggerThan
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new[] { 3, 9, 2, 8, 6, 5 };
            var printValSquared = from i in n
                                  where i * i > 20
                                  select i;
            

            foreach (int i in n.Where(i => i * i > 20))
            {
                Console.WriteLine(i);
            }
        }
    }
}
