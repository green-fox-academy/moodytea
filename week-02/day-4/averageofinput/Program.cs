using System;

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
			Console.WriteLine("number?");
			int n1 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("number?");
			int n2 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("number?");
			int n3 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("number?");
			int n4 = Convert.ToInt16(Console.ReadLine());
			Console.WriteLine("number?");
			int n5 = Convert.ToInt16(Console.ReadLine());

            int sum = n1 + n2 + n3 + n4 + n5;
            int av = sum / 5;
            Console.WriteLine("sum:" + sum + " average:" + av);
            Console.ReadLine();
        }
    }
}
