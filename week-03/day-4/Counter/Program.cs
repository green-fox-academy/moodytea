using System;
using System.Collections.Generic;

namespace Counter
{
    class Program
    {
        public static void Recurse(int remaining)
        {
            while (remaining != 0)
            {
                remaining -= 1;
                Console.WriteLine(remaining);
                
            }

            Recurse(remaining);

        }
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.

            int n = 40;
            Recurse(n + 1);
        }
    }
}
