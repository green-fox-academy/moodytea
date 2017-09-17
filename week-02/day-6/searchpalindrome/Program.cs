using System;

namespace searchpalindrome
{
    class Program
        public static void Reversed (string reversed) 

            int counter = reversed.Length;

            for (int i = counter-1; i >=0; i-- ){
                Console.Write(Convert.ToString(reversed[i]));
            }
        public static void SearchPalindrom(string input, List<string> output)
        {
            
        }
        static void Main(string[] args)
        {
			//Create a function named search palindrome following your current language's style guide. 
			//It should take a string, search for palindromes that at least 3 characters long and 
			//return a list with the found palindromes.

			Console.WriteLine("Give me a word or sentence to check: ");
			string userInput = Console.ReadLine();
			var List = new List<string> { };

			SearchPalindrome(userInput, List);

			Console.ReadLine();
        }
    }
}
