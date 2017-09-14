using System;

namespace animalsandlegs
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
            Console.WriteLine("Chick number?");
            int chick = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Pig number?");
            int pig = Convert.ToInt16(Console.ReadLine());
            int legs = chick*2 + pig*4;
            Console.WriteLine("Number of legs are " + legs);
            Console.ReadLine();
        }
    }
}
