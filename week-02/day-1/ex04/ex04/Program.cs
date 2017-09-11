using System;

namespace ex04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Give me your name, age, height (in meters) please!");
            String name = Console.ReadLine();
			int age = Convert.ToInt32(Console.ReadLine());
            Double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("So you are" + name +", "+ age + " years old, and " + Math.Round(height, 2) + " meters tall." );
        }
    }
}
