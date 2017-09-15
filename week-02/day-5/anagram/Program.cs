using System;
using System.Collections.Generic;

namespace anagram
{
    class Program
    {
        public static void Main(string[] args)
		{
			Console.WriteLine("Please input str no.1!");

			string ichi = Console.ReadLine();

            string ichiban = ichi.ToLower();

			Console.WriteLine("Please input str no.2!");

			string ni = Console.ReadLine();

            string niban = ni.ToLower();

			bool IsAnagram ( ichiban, niban){
                
    			if (ichiban.Length != niban.Length)
    				return false;

    			if (ichiban == niban)
    				return true;

                return IsAnagram();
            }


                

        }
    }
}
