using System;
using System.Collections.Generic;

namespace quoteswap
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List <string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };

			// Accidentally I messed up this quote from Richard Feynman.
			// Two words are out of place
			// Your task is to fix it by swapping the right words with code

			var tmp = list[5];
			list[5] = list[2];
			list[2] = tmp;

            for (int i = 0; i < list.Count; i++)
            {
                list[i] += " ";
                Console.Write(list[i]);
            }

            // Also, print the sentence to the output with spaces in between.
        }
    }
}
