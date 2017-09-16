using System;
using System.Collections.Generic;


namespace chess_table
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number!");
			int n = int.Parse(Console.ReadLine());

			int i, j;

			for (i = 1; i <= n; i++)
			{
				for (j = 1; j <= n; j++)
				{
					if ((i + j) %2 ==0)
						Console.Write("%");
					else
						Console.Write(" ");
				}
				Console.WriteLine();
			}

			Console.ReadLine();
		}
	}
}
