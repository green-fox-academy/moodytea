using System;

namespace printbigger
{
    class Program
    {
        static void Main(string[] args)
        {
			// Write a program that asks for two numbers and prints the bigger one

			Console.WriteLine("Two numbers!");
			double a = int.Parse(Console.ReadLine());
			double b = int.Parse(Console.ReadLine());
			double c = a - b;


            double Comparer = c > 0 ? a : b;
            if (c==0){
                Console.WriteLine("Warning! Equal!");
                return;
            }
            Console.WriteLine(Comparer);
              
			


			Console.ReadLine();
        }
    }
}
