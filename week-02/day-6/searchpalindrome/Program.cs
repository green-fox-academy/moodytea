using System;
using System.Collections.Generic;

namespace searchpalindrome
{
    class Program
	{
		public static string Reversed(string s)
		{
			int counter = s.Length;
			string t = "";

			for (int i = counter - 1; i >= 0; i--)
			{
				t = t + s[i];
			}
			return t;

		}
		public static bool IsPalindrome(string s)
		{
			return s.Equals(Reversed(s));
		}

        public static List<string> PalindromeSearch(string s)
		{
            var myList = new List<string>();
            for (int i = 3; i <= s.Length; i++){
                for (int j = 0; j <= s.Length-i; j++)
                {
                    if (IsPalindrome(s.Substring(j,i)))
                        myList.Add(s.Substring(j, i)) ;
                }
            }

            return myList;

		}
        static void Main(string[] args)
        {

			Console.WriteLine("Give me a word or sentence to check: ");
			string userInput = Console.ReadLine();

            PalindromeSearch(userInput).ForEach(Console.WriteLine);


            Console.ReadLine();
        }
    }
}
