using System;
using System.Collections.Generic;

namespace josephusproblem
{
    class Program
    {
        static void Main(string[] args)

        {
			Console.WriteLine("Enter the number!");
			int numberStart = int.Parse(Console.ReadLine());

            var numList = new List<int>();
            int number = 0;

            while (number <= numberStart)
			{
                numList.Add(number);
                number++;
            }



            Console.ReadLine();
        }
    }
}
