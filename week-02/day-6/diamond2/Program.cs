using System;

namespace diamond
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Enter a number!");
			int num = int.Parse(Console.ReadLine());

			int i, j, k;
			for (i = 1; i <= (num + 1) / 2; i++)
			{
				for (j = 1; j <=(num + 1) / 2-i; j++)
				{
					Console.Write(" ");
				}

				for (k = 1; k <= i * 2-1; k++)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}

			for (i = 1; i <= (num - 1) / 2; i++)
			{
				for (j = i; j >= 1; j--)
				{
					Console.Write(" ");
				}

				for (k = num-2*i; k >= 1; k--)
				{
					Console.Write("*");
				}
				Console.WriteLine("");
			}

			Console.Read();
		}
	}
}
