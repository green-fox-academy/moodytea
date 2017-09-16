using System;

namespace Reverse
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
            // - Create an array variable named `aj`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Reverse the order of the elements in `aj`
            // - Print the elements of the reversed `aj`
            int[] aj = new int[] { 3, 4, 5, 6, 7 };
            int counter = 1;
            var reversed = new int[aj.Length];
            for (int i = 0; i < aj.Length; i++)
			{
                reversed[i] = aj[aj.Length - counter];
				counter++;
			}
            PrintArray(reversed);
			Console.ReadLine();
		}
	}
}