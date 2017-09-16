using System;
using System.Collections.Generic;

namespace averageofinput
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
            int i;
            double sum = 0;
			Console.WriteLine("Please enter how many numbers will you have?");
			int n = Convert.ToInt16(Console.ReadLine());
            var element = new List<int>();
            for (i = 1; i <= n; i++){
                Console.WriteLine("Plese enter " + i +". number!");
                element.Add(Convert.ToInt16(Console.ReadLine()));

            }

            for (i = 0;  i <= n-1; i++)
            {
                sum = sum + element[i];
            }

            double av = sum / i;
            Console.WriteLine("sum:" + sum + " average:" + av);
            Console.ReadLine();
        }
    }
}
