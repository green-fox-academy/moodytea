using System;
using System.Collections.Generic;

namespace SumDigit
{
    class Program
    {
        public static int countUp(int num)
        {
            if (num != 0)
            {
                return(num % 10 + countUp(num / 10));
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n..

            int n = 895138;
            Console.WriteLine(countUp(n)); 
            Console.Read();
        }
    }
}
