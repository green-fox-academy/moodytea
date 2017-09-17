using System;
using System.Collections.Generic;
using System.Linq;

namespace anagram
{
    class Program
	{
		public static string ABC (string str)
		{
			char[] my = str.ToArray();
			Array.Sort(my);
			return new string(my);
		}
		
        public static bool IsAnagram (string s1, string s2)
		{
            if (s1 != s2 )
            {
                return false;
            }

			else
			{
				return true;
			}
		}
        public static void Main(string[] args)
		{
			Console.WriteLine("Please input str no.1!");

			string ichi = Console.ReadLine();

            ichi = ichi.ToLower();

            ichi = ABC(ichi);

			Console.WriteLine("Please input str no.2!");

			string ni = Console.ReadLine();

            ni = ni.ToLower();

            ni = ABC(ni);




            Console.WriteLine(IsAnagram(ichi, ni));


        }
    }
}
