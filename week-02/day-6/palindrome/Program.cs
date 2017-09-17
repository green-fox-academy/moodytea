using System;

namespace palindrome
{
    class Program
    {
        public static string Reversed (string s){
			int counter = s.Length;
            string t = "";

			for (int i = counter - 1; i >= 0; i--)
			{
                t = t+s[i];
			}
            return t;

        }
        static void Main(string[] args)
        {   
            Console.WriteLine("Give me a word: ");
            string str = Convert.ToString(Console.ReadLine());
            str = (str + Reversed(str));
            Console.WriteLine(str);
        }
    }
}
