using System;

namespace ex19
{
    class Program
    {
        static void Main(string[] args)
        {
			// Write a program that reads a number form the standard input,
			// If the number is zero or smaller it should print: Not enough
			// If the number is one it should print: One
			// If the number is two it should print: Two
			// If the number is more than two it should print: A lot

			Console.WriteLine("Hi honey! Please enter a number darling! It's for a super game!!!");
            double x = Convert.ToInt32(Console.ReadLine());
            if (x<=0){
                Console.WriteLine("Not enough!");
            }
			else if (x <= 1)
			{
				Console.WriteLine("One");
			}
			else if (x <= 2)
			{
				Console.WriteLine("Two");
			}
            else{
                Console.WriteLine("Wow, that's like... a lot!");
            }

            Console.ReadLine();
        }
    }
}
