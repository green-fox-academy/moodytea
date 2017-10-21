using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            var print1 = from i in n.GroupBy(val => val)
                                select i.Key.ToString() + " we have " + i.Count().ToString() + " times";
            foreach (var item in print1)
            {
                Console.WriteLine(item);
            }

            var res = n.GroupBy(val => val);
            foreach (var v in res)
            {
                Console.WriteLine(v.Key.ToString() + " we have " + v.Count().ToString() + " times");
            }
        }
    }
}
