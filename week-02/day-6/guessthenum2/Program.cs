using System;
using System.Collections.Generic;

namespace guessthenum
{
	class Program
	{
		static void Main(string[] args)
		{
            int lives = 1;
            Console.WriteLine("Welcome to GuessTheNumber! You have " + lives + " lives! What is the maximum range of numbers you'd like to guess? ");
            int max = int.Parse(Console.ReadLine());
			Random randy = new Random();
            int randyInt = randy.Next(1, max+1);
			int numGuessed;


            do
			{
				Console.WriteLine("Guess the number!");
                Console.WriteLine("You have " + lives + " lives left.");
				numGuessed = int.Parse(Console.ReadLine());

				if (numGuessed > randyInt)
                {
                    lives--;
					Console.WriteLine("The stored number is lower");
				}

				else if (numGuessed < randyInt)
                {
                    lives--;
					Console.WriteLine("The stored number is higher");
				}
			}
            while (randyInt != numGuessed && lives!=0);

			if (lives == 0)
				Console.WriteLine("Game over, try again!");

			if (randyInt == numGuessed)
			Console.WriteLine("You found the number");





			Console.ReadLine();
		}
	}
}
