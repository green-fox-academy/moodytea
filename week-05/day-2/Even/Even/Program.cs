using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            IEnumerable<int> printEven1 = 
                from i in n
                where i % 2 == 0
                select i;
            foreach (var item in printEven1)
            {
                Console.WriteLine(item);
            }

            //printEven2
            foreach (int i in n.Where(i => i % 2 == 0))
            {
                Console.WriteLine(i);
            }

            IEnumerable<int> printEven3 = n.Where(y => y % 2 == 0);
            foreach (var item in printEven3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
