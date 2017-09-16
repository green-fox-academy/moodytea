using System;

namespace ex26
{
    class Program
    {
        static void Main(string[] args)

		{ 
            // Create a program that asks for two numbers
          // If the second number is not bigger than the first one it should print:
          // "The second number should be bigger"
          //
          // If it is bigger it should count from the first number to the second by one
          //
          // example:
          //
          // first number: 3, second number: 6, should print:
          //
          // 3
          // 4
          // 5

            bool start = true;

            while (start == true)
            {
                Console.WriteLine("Please enter two numbers! I'll list all the integers between them, ONLY FOR YOU, just this once!");
                int num1 = int.Parse(Console.ReadLine());
                int num2 = int.Parse(Console.ReadLine());
                if (num1 >= num2)
                {
                    Console.WriteLine("The second should be bigger!");
                    start = true;
                }

                else while (num1 < num2)
                    {
                        Console.WriteLine(num1);
                        num1++;

                    }

                }
                Console.ReadLine();
            
         }
     }
}
