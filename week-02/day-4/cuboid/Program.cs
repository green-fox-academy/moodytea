using System;

namespace cuboid
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000
            double length =2;
            double breadth =3;
            double height =5;

            double vol =length*breadth*height;
            double surf =2*((length + height)+(length+breadth)+(breadth+height));

            Console.WriteLine("Surface Area: " + surf);
            Console.WriteLine("Volume: " + vol);
            Console.ReadLine();
        }
    }
}
