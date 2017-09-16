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
            for (i = 1; i <= (num + 1) /2; i++)
			{
				for (j = 1; j <= num - i; j++)
				{
					Console.Write("1");
				}

				for (k = 1; k < i * 2; k++)
				{
					Console.Write("8");
				}
				Console.WriteLine("");
			}

            for (i = 1; i <= (num - 1) / 2; i++)
			{
                for (j = num-2*i; j > 1; j--)
				{
					Console.Write("1");
				}

                for (k = i-2; k >= 1; k--)
				{
					Console.Write("8");
				}
				Console.WriteLine("");
			}

			Console.Read();
        }
    }
}
