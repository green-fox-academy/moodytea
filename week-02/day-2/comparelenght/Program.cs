﻿using System;

namespace comparelenght
{
    class Program
    {
        static void Main(string[] args)
        {
			// - Create an array variable named `p1`
			//   with the following content: `[1, 2, 3]`
			// - Create an array variable named `p2`
			//   with the following content: `[4, 5]`
			// - Print if `p2` has more elements than `p1`
			Console.ReadLine();

            int[] p1 = { 1, 2, 3 };
            int[] p2 = { 4, 5 };

            if (p1.Length > p2.Length){
                Console.WriteLine("p1 is bigger");
            }
			else if (p2.Length > p1.Length)
			{
				Console.WriteLine("p2 is bigger");
			}
        }
    }
}
