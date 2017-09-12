using System;

namespace append_a
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create a string variable named `am` and assign the value `kuty` to it
            // - Write a function called `appendA` that gets a string as an input
            //   and appends an 'a' character to its end
            // - Print the result of `appendA(am)`
            string am = "kuty";
            string AppenndA (string input){
                return input + 'a';
                }
            Console.WriteLine(AppenndA(am));
            Console.ReadLine();
        }
    }
}
