using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PositiveSquared
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var printPositive = from i in n
                                where i > 0
                                select i*i;
            

            foreach (int i in n.Where(i => i > 0).Select(x => x * x))
            {
                Console.WriteLine(i);
            }
        }
    }
}
