using System;

namespace SwapElements
{
	class Program
	{
		static void PrintArray(string[] arr)
		{
			for (int i = 0; i < arr.Length; i++)
			{
				System.Console.Write(arr[i] + "{0}", i < arr.Length - 1 ? " " : "");
			}
			System.Console.WriteLine();
		}
		static void Main(string[] args)
		{
			// - Create an array variable named `abc`
			//   with the following content: `["first", "second", "third"]`
			// - Swap the first and the third element of `abc`
			string[] abc = new string[] { "first", "second", "third" };
			string temp = abc[0];
			abc[0] = abc[2];
			abc[2] = temp;

			PrintArray(abc);

			Console.ReadLine();

		}
	}
}
