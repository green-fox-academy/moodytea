using System;

namespace pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
			// Write a program that reads a number from the standard input, then draws a
			// pyramid like this:
			//
			//
			//    *
			//   ***
			//  *****
			// *******
			//
			// The pyramid should have as many lines as the number was

			Console.WriteLine("Enter a number!");
			int num = int.Parse(Console.ReadLine());

			int i, j, k;
			for (i = 1; i <= num; i++)
			{
				for (j = 1; j <= num - i; j++)
				{
					Console.Write(" ");
				}
				for (k = 1; k <= i; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}

            Console.Read();
        }
    }
}
