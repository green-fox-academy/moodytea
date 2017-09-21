using System;
using System.Collections.Generic;

namespace Counter
{
    class Program
    {
        public static void countDown(int integer)
        {
            if (integer == 1)
            {
                Console.WriteLine(integer);
            }
            else
            {
                Console.WriteLine(integer);
                integer--;
                countDown(integer);
            }
        }
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.

            int n = 40;
            countDown(n);
            Console.Read();
        }
    }
}
