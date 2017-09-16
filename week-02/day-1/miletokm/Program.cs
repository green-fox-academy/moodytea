using System;

namespace ex15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for an integer that is a distance in kilometers,
            // then it converts that value to miles and prints it
            Console.WriteLine("Please input the distance in kms!");
            int distance = Convert.ToInt32(Console.ReadLine());
            double distanceInMiles = distance * 1.609347;
            Console.WriteLine("So it's " + distanceInMiles + " miles! This converter is a five star deserving app already, don't you agree?");
			Console.ReadLine();
        }
    }
}
