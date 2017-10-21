using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageOfOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            var printEven = from i in n
                            where i % 2 != 0
                            select i;
            Console.WriteLine(printEven.Average());

            var printEven2 = n.Where(i => i % 2 != 0).Average();
            Console.WriteLine(printEven2);
        }
    }
}
