using System;

namespace ex03
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Give me 3 names!");
			String one = Console.ReadLine();
			String two = Console.ReadLine();
			String three = Console.ReadLine();
			Console.WriteLine("Hi " + one);
			Console.WriteLine("Hi " + two);
			Console.WriteLine("Hi " + three);
			Console.Read();

		}
	}
}
