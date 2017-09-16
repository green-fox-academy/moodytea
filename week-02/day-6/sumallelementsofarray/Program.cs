using System;

namespace SumAll
{
	class Program
	{
		static void PrintArray(int[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				Console.Write("Element({0})={1} \n", i, arr[i]);
			}
			Console.WriteLine();
		}

		static void Main(string[] args)
		{
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`
            int[] ai = new int[] { 3, 4, 5, 6, 7 };
            PrintArray(ai);
			
            int sum = 0;
            Array.ForEach(ai, delegate (int i) { sum += i; });
            Console.WriteLine("And the sum of them are " + sum + ".");

			Console.ReadLine();
		}
	}
}