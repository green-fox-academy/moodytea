using System;
using System.Collections.Generic;



namespace armstrong
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number!");
            int number = int.Parse(Console.ReadLine());
            int numberSaved = number;

            int length = number.ToString().Length;

            var digits = new List<int>();
            while (number>0)
			{
				digits.Add(number % 10);
                number /= 10;
			}

            int sum = 0;


            foreach (int element in digits){
                int squared = (int)Math.Pow(element, length);
                sum += squared;
    				
            }

            if (numberSaved == sum)
			{
				Console.WriteLine("It's an Armstrong number!");
			}
			else Console.WriteLine("It's not an Armstrong number!");



            Console.ReadLine();
        }
    }
}
