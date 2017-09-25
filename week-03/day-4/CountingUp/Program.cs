using System;
using System.Collections.Generic;

namespace CountingUp
{
    class Program
    {
        public static void countUp(int num)
        {
            if (num > 1)
            {
                countUp(num - 1);
            }
            Console.WriteLine(num - 1);
        }
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n..

            int n = 40;
            countUp(n+1);
            Console.Read();
        }
    }
}
