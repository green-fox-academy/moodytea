using System;

namespace factorio
{
    class Program
    {
        static void Main(string[] args)
        {
			// - Create a function called `factorio`
			//   that returns it's input's factorial
			Console.WriteLine("Enter a number!");
			int number = int.Parse(Console.ReadLine());

			int Factorio(int n)
			{
				for (int i = 1; i < number; i++)
					n = n * i;
				return n;


			}
			Console.WriteLine(Factorio(number));
			Console.ReadLine();
        }
    }
}
