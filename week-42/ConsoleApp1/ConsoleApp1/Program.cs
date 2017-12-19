using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(1990, 04, 11);
            Console.WriteLine(date.DayOfWeek);
            Console.ReadKey();
        }
    }
}
