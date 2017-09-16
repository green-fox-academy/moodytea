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
            int number = 1;

            while (number <= numberStart)
			{
                numList.Add(number);
                number++;
            }

            var length = numList.Count;

            while (length > 1)
            {
                if (length % 2 == 0)
                {
                    int i = ;
                    numList.RemoveAt(i + 1);
                }
                else if (length % 2 != 0)
                {
                    int i = 0;
                    numList.RemoveAt(i + 1);
                }
            }



            Console.ReadLine();
        }
    }
}
