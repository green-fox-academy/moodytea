using System;

namespace ex21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a program that asks for two numbers
            // The first number represents the number of girls that comes to a party, the
            // second the boys
            // It should print: The party is exellent!
            // If the the number of girls and boys are equal and there are more people coming than 20
            //
            // It should print: Quite cool party!
            // It there are more than 20 people coming but the girl - boy ratio is not 1-1
            //
            // It should print: Average party...
            // If there are less people coming than 20
            //
            // It should print: Sausage party
            // If no girls are coming, regardless the count of the people
            Console.WriteLine("Hello there party-person! Please count how many people you guys have for the party!");
            Console.WriteLine("So, how many guys are there?");
            int boys = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("So, how many girls are there?");
            int girls = Convert.ToInt16(Console.ReadLine());
			
            if (girls==0){
                Console.WriteLine("So it's a sasuge party! Is there any beer at least?");
            }
            else if  (girls+boys>=20 && girls==boys)
			{
                Console.WriteLine("Excelent party! Wait for me, dude!");

			}
            else if (girls + boys>=20 && girls != boys)
			{
				Console.WriteLine("Cool party! I might be there, man!");

			}
            else {
                Console.WriteLine("Average party, man! I'm not coming then.");
            }

			Console.ReadLine();
        }
    }
}
