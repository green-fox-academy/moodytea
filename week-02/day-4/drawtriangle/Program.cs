using System;

namespace drawtriangle
{
    class Program
    {
        static void Main(string[] args)
		{   // Write a program that reads a number from the standard input, then draws a
			// triangle like this:
			//
			// *
			// **
			// ***
			// ****
			//
			// The triangle should have as many lines as the number was



            Console.WriteLine("Enter a number!");
            int num = int.Parse(Console.ReadLine());

			int i, j;
            for (i = 1; i <= num; i++)
			{
                for (j = 1; j <= i; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}
			
            Console.ReadLine();
        }
    }
}
