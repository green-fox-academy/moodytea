using System;

namespace printarguments
{
	class Program

	{
        static void Printer(){
			string input = (Console.ReadLine());

			if (!input.Equals(""))
			{
				Console.WriteLine(input);
			}

		}

		static void Main(string[] args)
		{
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...
            Console.WriteLine("Enter strings!");
            Printer();
			Console.ReadLine();
		}
	}
}
