using System;

namespace ex18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the odd examiner! Enter a number and it'll print whether or not it's an odd number! Sooo fun!");
            Console.WriteLine(Convert.ToInt32(Console.ReadLine())%2==0);
            Console.ReadLine();
        }
    }
}
