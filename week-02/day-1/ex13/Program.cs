using System;

namespace ex13
{
    class Program
    {
        static void Main(string[] args)
        {
			int currentHours = 14;
			int currentMinutes = 34;
			int currentSeconds = 42;

            // Write a program that prints the remaining seconds (as an integer) from a
            // day if the current time is represented bt the variables
            int allSeconds = 24 * 60 * 60;
            int remainingSeconds = allSeconds - (currentHours * 60 * 60 + currentMinutes * 60 + currentSeconds);
            Console.WriteLine(remainingSeconds);
			Console.ReadLine();
        }
    }
}
