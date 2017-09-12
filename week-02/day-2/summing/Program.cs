using System;

namespace summing
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
           Console.WriteLine("Enter a number!");
           int number = int.Parse(Console.ReadLine());
           
           int Summing (int n){
               for (int i = 0; i< number; i++)
    		   n = n + i;
    		   return n;  
         

            }
            Console.WriteLine(Summing(number));
            Console.ReadLine();
        }
    }
}
